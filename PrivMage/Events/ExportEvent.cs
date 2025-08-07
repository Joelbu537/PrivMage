using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using PrImage.JsonBlueprints;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivMage
{
    public partial class FormMain : Form
    {
        private void buttonEditExport_Click(object sender, EventArgs e)
        {
            if (listViewEditExport.SelectedItems.Count > 0)
            {
                var selectedItem = listViewEditExport.SelectedItems[0];
                if (selectedItem.Tag is LibraryContent content)
                {
                    var dialog = new CommonOpenFileDialog
                    {
                        IsFolderPicker = true,
                        Multiselect = false,
                        InitialDirectory = @"C:\",
                        Title = "Select Export Directory"
                    };

                    if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                    {
                        string path = dialog.FileName;
                        if (!Directory.Exists(path))
                        {
                            MessageBox.Show("The selected path is not a valid directory.", "Invalid Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Actual export shit
                        List<JsonBlueprints.Image> images = GetImageList(content.Id);

                        for (int i = 0; i < images.Count; i++)
                        {
                            string fileName = Path.Combine(path, $"{content.Name}_{i}.{Program.GetImageFormat(images[i].data)}");
                            File.WriteAllBytes(fileName, images[i].data);
                        }
                        MessageBox.Show($"Exported {images.Count} images to {path}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void listViewEditExport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewEditExport.SelectedItems.Count > 0)
            {
                buttonEditExport.Enabled = true;
            }
            else
            {
                buttonEditExport.Enabled = false;
            }
        }
    }
}
