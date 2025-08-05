using System.Runtime.CompilerServices;
using PrImage.JsonBlueprints;

namespace PrImage
{
    public partial class FormMain : Form
    {
        private void buttonEditModifyAttach_Click(object sender, EventArgs e)
        {

        }
        private void buttonEditModifyRemove_Click(object sender, EventArgs e)
        {

        }
        private void buttonEditModifyInsert_Click(object sender, EventArgs e)
        {

        }
        private void buttonEditModifySelect_Click(object sender, EventArgs e)
        {
            if(listViewEditModify.SelectedItems.Count > 0)
            {
                LibraryContent content = listViewEditModify.SelectedItems[0].Tag as LibraryContent;
                if(content != null)
                {
                    listViewEditModify.Items.Clear();
                    List<JsonBlueprints.Image> oldImages = GetImageList(content.Id);
                    foreach (JsonBlueprints.Image img in oldImages)
                    {
                        listViewEditModify.Items.Add(img.id.ToString());
                    }
                    buttonEditModifyAttach.Enabled = true;
                    buttonEditModifySelect.Enabled = false;
                }
            }
        }
    }
}