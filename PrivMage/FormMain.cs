using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using PrImage.JsonBlueprints;
using PrivMage.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrImage
{
    public partial class FormMain : Form
    {
        private List<LibraryContent> LibraryContents;
        private List<byte[]> Images = new List<byte[]>();
        private Dictionary<string, LibraryContent> LibraryContentsDictionary = new Dictionary<string, LibraryContent>();
        private int _currentViewImageIndex = 1;
        public int CurrentViewImageIndex
        {
            get
            {
                return _currentViewImageIndex;
            }
            set
            {
                if (value < 1 || value > Images.Count)
                {
                    throw new ArgumentOutOfRangeException("Index out of range"); // Replace at some point in time. This should theoretically never happen, but just in case.
                }
                else
                {
                    OnCurrentImageIndexChanged(value);
                    _currentViewImageIndex = value;
                    CorrectButtonStates();
                }
            }
        }
        private byte[] key;
        private byte[] iv;
        private byte[] salt;
        public FormMain()
        {
            InitializeComponent();
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(FormMain_KeyDown);

            Debug.WriteLine($"Base loaded! RAM: {GC.GetTotalMemory(false) / 1024 / 1024} MB");
            StartMemoryWatcher();

            // Initialize Library
            if (File.Exists("lib"))
            {
                Debug.WriteLine("Library file found. Attempting to load.");
                PrImage.JsonBlueprints.LibraryFile library = JsonConvert.DeserializeObject<LibraryFile>(File.ReadAllText("lib"));
                Debug.WriteLine($"Library serialized! RAM: {GC.GetTotalMemory(false) / 1024 / 1024} MB");
                if (library.MD5 != "")
                {
                    Debug.WriteLine("Library file is not empty. Attempting to decrypt.");
                    salt = library.Salt;
                    GC.Collect();
                    // Decrypt Library
                    using (FormPassword formPassword = new FormPassword(library.Salt))
                    {
                        if (formPassword.ShowDialog() == DialogResult.OK)
                        {
                            key = formPassword.Key.GetBytes(32);
                            iv = formPassword.Key.GetBytes(16);

                            string decryptedContent = DecryptBase64ToString(library.Content, key, iv);
                            if (Program.ComputeMD5Hash(Encoding.UTF8.GetBytes(decryptedContent)) != library.MD5)
                            {
                                Debug.WriteLine("MD5 hash mismatch. Possible tampering or incorrect password.");
                                MessageBox.Show("MD5 hash mismatch. Incorrect password or corrupted data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                Application.Exit();
                                return;
                            }
                            LibraryContents = JsonConvert.DeserializeObject<List<LibraryContent>>(decryptedContent);
                        }
                        else
                        {
                            Debug.WriteLine("User cancelled password input.");
                            this.Close();
                            Application.Exit();
                            return;
                        }
                    }

                    library = null;
                    GC.Collect();
                    Debug.WriteLine("Library file loaded successfully.");
                    Debug.WriteLine($"Library decrypted! RAM: {GC.GetTotalMemory(false) / 1024 / 1024} MB");

                    // Load cover images from library contents
                    ImageList imageList = new ImageList();
                    imageList.ImageSize = new Size(384, 384);
                    listViewSelect.LargeImageList = imageList;
                    listViewSelect.SelectedIndexChanged += OnListViewSelectedIndexChanged;

                    foreach (LibraryContent content in LibraryContents)
                    {
                        // Add to Select ListView
                        if (content.Data != null && content.Data.Length > 0)
                        {
                            try
                            {
                                using (var ms = new MemoryStream(content.Data))
                                {
                                    imageList.Images.Add(content.Name, System.Drawing.Image.FromStream(ms));
                                    LibraryContentsDictionary[content.Name] = content;
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                Debug.WriteLine($"Ungültige Bilddaten für {content.Name}: {ex.Message}");
                                imageList.Images.Add(content.Name, Resources.fileError);
                                LibraryContentsDictionary[content.Name] = content;
                            }
                        }

                        ListViewItem item = new ListViewItem(content.Name);
                        item.ImageKey = content.Name;

                        item.Tag = content;

                        listViewSelect.Items.Add(item);

                        listViewEditExport.Items.Add(new ListViewItem
                        {
                            Text = content.Name,
                            Tag = content
                        });
                    }
                    Debug.WriteLine($"Library displayed! RAM: {GC.GetTotalMemory(false) / 1024 / 1024} MB");
                }
                else
                {
                    Debug.WriteLine("Library file empty. Creating a new one.");
                    CreateNewLibrary();
                }
            }
            else
            {
                Debug.WriteLine("Library file empty. Creating a new one.");
                CreateNewLibrary();
            }

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Listview-Scaling
            listViewEditNewImages.Columns[0].Width = listViewEditNewImages.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 4;
            listViewEditExport.Columns[0].Width = listViewEditExport.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 4;
            splitContainerSelect.SplitterDistance = splitContainerSelect.Width - splitContainerSelect.Panel2MinSize;
        }
        public void CorrectButtonStates()
        {
            if (CurrentViewImageIndex > 1)
            {
                buttonViewPrevious.Enabled = true;
            }
            else
            {
                buttonViewPrevious.Enabled = false;
            }
            if (CurrentViewImageIndex < Images.Count)
            {
                buttonViewNext.Enabled = true;
            }
            else
            {
                buttonViewNext.Enabled = false;
            }
        }
        private void CreateNewLibrary()
        {

            using (FormPassword formPassword = new FormPassword())
            {
                if (formPassword.ShowDialog() == DialogResult.OK)
                {
                    Debug.WriteLine("Creating new library file");
                    key = formPassword.Key.GetBytes(32);
                    iv = formPassword.Key.GetBytes(16);

                    LibraryFile file = new LibraryFile { Salt = formPassword.Salt, MD5 = "", Content = "" };
                    salt = file.Salt;

                    File.WriteAllText("lib", JsonConvert.SerializeObject(file));
                }
                else
                {
                    Debug.WriteLine("User cancelled password input.");
                    Application.Exit();
                    return; // Exit if user cancels
                }
            }
            LibraryContents = new List<LibraryContent>();
            Debug.WriteLine("New library file created.");
        }
        public List<JsonBlueprints.Image> GetImageList(int id)
        {
            try
            {
                string fileContent = System.IO.File.ReadAllText(id.ToString());
                ImageCollection imageCollection = JsonConvert.DeserializeObject<ImageCollection>(fileContent);
                string decrypted = DecryptBase64ToString(imageCollection.Content, key, iv);
                List<JsonBlueprints.Image> images = Newtonsoft.Json.JsonConvert.DeserializeObject<List<JsonBlueprints.Image>>(decrypted);
                if (imageCollection.MD5 == Program.ComputeMD5Hash(System.Text.Encoding.UTF8.GetBytes(decrypted)))
                {
                    Debug.WriteLine("MD5 hash matches, proceeding with image loading.");
                    return images;
                }
                else
                {
                    Debug.WriteLine("MD5 hash does not match, aborting image loading.");
                    MessageBox.Show("The content is corrupted or has been tampered with.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            catch
            {
                return null;
            }

        }
        private void CheckMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            ImageTracker.Report();
        }
        private System.Windows.Forms.Timer memoryCheckTimer;
        private void StartMemoryWatcher()
        {
            memoryCheckTimer = new System.Windows.Forms.Timer();
            memoryCheckTimer.Interval = 5000; // alle 5 Sekunden
            memoryCheckTimer.Tick += (s, e) => CheckMemory();
            memoryCheckTimer.Start();
        }
    }
}
