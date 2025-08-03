using Newtonsoft.Json;
using PrImage.JsonBlueprints;
using PrivMage.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrImage
{
    public partial class FormMain : Form
    {
        private void OnListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSelect.SelectedItems.Count > 0)
            {
                buttonSelectRead.Enabled = true;
                ListViewItem selectedItem = listViewSelect.SelectedItems[0];
                LibraryContent content = selectedItem.Tag as LibraryContent;

                if (content != null)
                {
                    labelSelectInfoName.Text = $"Title: {content.Name}";
                    labelSelectInfoDate.Text = $"Created: {content.DateCreated}({content.DateModified})";
                    labelSelectInfoTags.Text = $"Tags: {string.Join(", ", content.Tags)}";
                    labelSelectInfoID.Text = $"ID: {content.Id}";
                    try
                    {
                        using (var ms = new MemoryStream(content.Data))
                        {
                            if (pictureBoxSelectPreview.Image != null)
                            {
                                pictureBoxSelectPreview.Image.Dispose();
                            }
                            pictureBoxSelectPreview.Image = System.Drawing.Image.FromStream(ms);
                            ImageTracker.Track(pictureBoxSelectPreview.Image);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Debug.WriteLine($"Ungültige Bilddaten für {content.Name}: {ex.Message}");
                        if( pictureBoxSelectPreview.Image != null)
                        {
                            pictureBoxSelectPreview.Image.Dispose();
                        }
                        pictureBoxSelectPreview.Image = Resources.fileError;
                        ImageTracker.Track(pictureBoxSelectPreview.Image);
                    }
                }
            }
            else
            {
                buttonSelectRead.Enabled = false;
            }
        }
        private void buttonSelectRead_Click(object sender, EventArgs e)
        {
            buttonSelectRead.Text = "Loading...";
            buttonSelectRead.Enabled = false;
            int id = LibraryContentsDictionary[listViewSelect.SelectedItems[0].ImageKey].Id;
            Debug.WriteLine($"Reading content with ID: {id}");
            List<JsonBlueprints.Image> images = GetImageList(id);

            if(images == null || images.Count == 0)
            {
                Debug.WriteLine("Error while trying to load ImageCollection " + id);
                MessageBox.Show("Data corrupted or removed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                buttonSelectRead.Text = "Read";
                buttonSelectRead.Enabled = true;
                return;
            }

            // Images mit den Bildern befüllen

            List<byte[]> byteImages = new List<byte[]>();
            foreach (JsonBlueprints.Image img in images)
            {
                if (img.data != null && img.data.Length > 0)
                {
                    byteImages.Add(img.data);
                }
                else
                {
                    Debug.WriteLine($"Image with ID {img.id} has no data.");
                }
            }

            for(int i = 0; i < images.Count; i++)
            {
                if (images[i] != null)
                {
                    images[i] = null;
                }
            }
            images.Clear();
            GC.Collect();


            for (int i = 0; i < Images.Count; i++)
            {
                Images[i] = null;
            }
            Images.Clear();
            Images = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();

            if (pictureBoxView.Image != null)
            {
                pictureBoxView.Image.Dispose();
                pictureBoxView.Image = null;
            }
            Images = byteImages;
            byteImages = null;

            OnImageCollectionChanged();



            Debug.WriteLine("Images set to new List!");
            tabControlMain.SelectedIndex = 1;
            buttonSelectRead.Enabled = true;
            buttonSelectRead.Text = "Read";
            Debug.WriteLine($"New ImageCollection loaded! RAM: {GC.GetTotalMemory(false) / 1024 / 1024} MB");
        }
        private void listViewSelect_ItemActivate(object sender, EventArgs e)
        {
            buttonSelectRead_Click(sender, e);
        }
    }
}
