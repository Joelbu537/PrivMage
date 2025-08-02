using Newtonsoft.Json.Linq;
using PrImage.JsonBlueprints;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrImage
{
    public partial class FormMain : Form
    {
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (tabControlMain.SelectedIndex == 0)
            {
                if(e.KeyCode == Keys.Enter && listViewSelect.SelectedItems.Count > 0)
                {
                    int id = LibraryContentsDictionary[listViewSelect.SelectedItems[0].ImageKey].Id;

                    List<JsonBlueprints.Image> images = GetImageList(id);

                    // Images mit den Bildern befüllen

                    List<byte[]> byteImages = new List<byte[]>();
                    foreach (JsonBlueprints.Image img in images)
                    {
                        if (img.data != null && img.data.Length > 0)
                        {
                            byteImages.Add(img.data);
                            Debug.WriteLine($"Image {img.id} loaded");
                        }
                        else
                        {
                            Debug.WriteLine($"Image with ID {img.id} has no data.");
                        }
                    }
                    Images = byteImages;
                    OnImageCollectionChanged();
                    Debug.WriteLine("Images set to new List!");
                    tabControlMain.SelectedIndex = 1;
                    buttonSelectRead.Enabled = true;
                    buttonSelectRead.Text = "Read";
                    e.Handled = true;
                }
            }
            else if(tabControlMain.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up)
                {
                    if (CurrentViewImageIndex > 1)
                    {
                        CurrentViewImageIndex--;
                    }
                }
                else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Down || e.KeyCode == Keys.Space || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
                {
                    if (CurrentViewImageIndex < Images.Count)
                    {
                        CurrentViewImageIndex++;
                    }
                }
                else if (e.KeyCode == Keys.Escape)
                {
                    tabControlMain.SelectedIndex = 0;
                }
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }

        }
        private void FormMain_Resize(object sender, EventArgs e)
        {
            listViewEditNewImages.Columns[0].Width = listViewEditNewImages.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 4;
            listViewEditExport.Columns[0].Width = listViewEditExport.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 4;
        }
        private void buttonReturnToSelect_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
        }
    }
}
