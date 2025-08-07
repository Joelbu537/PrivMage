using Microsoft.WindowsAPICodePack.Dialogs;
using PrImage.JsonBlueprints;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PrivMage
{
    public partial class FormMain : Form
    {
        string lastPath = @"C:\";
        private void buttonEditNewCover_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = false,
                Multiselect = false,
                InitialDirectory = lastPath,
                Title = "Select New Cover Image",
                Filters = 
                {
                    new CommonFileDialogFilter("Image Files", "*.jpg;*.jpeg;*.png;*.bmp;*.webp"),
                },
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string selectedImage = dialog.FileName;
                if (File.Exists(selectedImage))
                {
                    lastPath = Path.GetDirectoryName(selectedImage);
                    textBoxEditNewCoverPath.Text = selectedImage;
                    textBoxEditNewCoverPath.BackColor = System.Drawing.Color.White;
                }
                else
                {
                    MessageBox.Show("The selected path is not a valid directory.", "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxEditNewCoverPath.Text = string.Empty;
                    textBoxEditNewCoverPath.BackColor = System.Drawing.Color.Yellow;
                }
            }

            textBoxEditNewTitle_TextChanged(sender, e);
        }
        private void textBoxEditNewTitle_TextChanged(object sender, EventArgs e)
        {
            if(textBoxEditNewTitle.Text.Length > 0 && textBoxEditNewCoverPath.Text != string.Empty && listViewEditNewImages.Items.Count != 0)
            {
                buttonEditNewCreate.Enabled = true;
            }
            else
            {
                buttonEditNewCreate.Enabled = false;
                buttonEditNewRemoveImage.Enabled = false;
            }
        }
        private void buttonEditNewAddImage_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = false,
                Multiselect = true,
                InitialDirectory = lastPath,
                Title = "Select Image",
                Filters =
                {
                    new CommonFileDialogFilter("Image Files", "*.jpg;*.jpeg;*.png;*.bmp;*.webp"),
                },
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                List<string> selectedImages = dialog.FileNames.ToList();
                bool error = false;
                foreach (string image in selectedImages)
                {
                    if (!File.Exists(image))
                    {
                        selectedImages.Remove(image);
                        error = true;
                    }
                    else
                    {
                        lastPath = Path.GetDirectoryName(image);
                        listViewEditNewImages.Items.Add(image);
                    }
                }
                if (error)
                {
                    MessageBox.Show("One or multiple selected images could not be processed and have been excluded.", "Invalid Images", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                textBoxEditNewTitle_TextChanged(sender, e);
            }
        }
        private void listViewEditNewImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewEditNewImages.SelectedItems.Count > 0)
            {
                buttonEditNewRemoveImage.Enabled = true;
            }
            else
            {
                buttonEditNewRemoveImage.Enabled = false;
            }
        }
        private void buttonEditNewRemoveImage_Click(object sender, EventArgs e)
        {
            List<ListViewItem> removalList = new List<ListViewItem>();
            foreach(int i in listViewEditNewImages.SelectedIndices)
            {
                removalList.Add(listViewEditNewImages.Items[i]);
            }
            foreach(ListViewItem item in removalList)
            {
                listViewEditNewImages.Items.Remove(item);
            }
        }
        private void buttonEditNewCreate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int id = 0;
            do
            {
                id = random.Next(0, int.MaxValue);
            }
            while (File.Exists(id.ToString()));

            List<JsonBlueprints.Image> images = new List<JsonBlueprints.Image>();
            foreach (ListViewItem item in listViewEditNewImages.Items)
            {
                if (File.Exists(item.Text))
                {
                    images.Add(new JsonBlueprints.Image
                    {
                        id = item.Index,
                        data = File.ReadAllBytes(item.Text)
                    });
                }
                else
                {
                    MessageBox.Show($"The file {item.Text} does not exist.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            string content = Newtonsoft.Json.JsonConvert.SerializeObject(images);
            JsonBlueprints.ImageCollection imageCollection = new JsonBlueprints.ImageCollection
            {
                MD5 = Program.ComputeMD5Hash(System.Text.Encoding.UTF8.GetBytes(content)),
                Content = EncryptStringToBase64(content, key, iv)
            };
            LibraryContent lib = new JsonBlueprints.LibraryContent
            {
                Name = textBoxEditNewTitle.Text,
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                Tags = textBoxEditNewTags.Lines.ToList<string>(),
                Id = id,
                Data = File.ReadAllBytes(textBoxEditNewCoverPath.Text)
            };
            foreach (string tag in lib.Tags)
            {
                tag.Replace(" ", "_");
            }
            LibraryContents.Add(lib);
            File.WriteAllText($"{id}", Newtonsoft.Json.JsonConvert.SerializeObject(imageCollection));
            LibraryFile libraryFile = new LibraryFile
            {
                Salt = salt,
                MD5 = Program.ComputeMD5Hash(System.Text.Encoding.UTF8.GetBytes(Newtonsoft.Json.JsonConvert.SerializeObject(LibraryContents))),
                Content = EncryptStringToBase64(Newtonsoft.Json.JsonConvert.SerializeObject(LibraryContents), key, iv)
            };
            File.WriteAllText("lib", Newtonsoft.Json.JsonConvert.SerializeObject(libraryFile));
            listViewEditNewImages.Items.Clear();
            textBoxEditNewCoverPath.Text = string.Empty;
            textBoxEditNewTitle.Text = string.Empty;
            MessageBox.Show("New image collection created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
