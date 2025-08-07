using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivMage
{
    public partial class FormMain : Form
    {
        public void OnImageCollectionChanged()
        {
            Debug.WriteLine("Image collection changed. Count: " + Images.Count);
            labelViewMaxImages.Text = $"/{Images.Count}";
            CurrentViewImageIndex = 1;
            CorrectButtonStates();
        }
        private void checkBoxViewOrignianResolution_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("Original resolution checkbox changed. Checked: " + checkBoxViewOrignianResolution.Checked);
            pictureBoxView.SizeMode = checkBoxViewOrignianResolution.Checked
                ? PictureBoxSizeMode.CenterImage
                : PictureBoxSizeMode.Zoom;
        }
        private void textBoxViewCurrentImage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxViewCurrentImage.Text)) return;

            try
            {
                int index = int.Parse(textBoxViewCurrentImage.Text);
                if (index < 1 || index > Images.Count)
                    throw new ArgumentOutOfRangeException("Index out of range");

                CurrentViewImageIndex = index;
            }
            catch
            {
                textBoxViewCurrentImage.Text = CurrentViewImageIndex.ToString();
            }
        }
        private void OnCurrentImageIndexChanged(int index)
        {
            Debug.WriteLine("Current image index changed to: " + index);

            try
            {
                // Altes Bild freigeben
                if (pictureBoxView.Image != null)
                {
                    pictureBoxView.Image.Dispose();
                    pictureBoxView.Image = null;
                }

                using (var ms = new MemoryStream(Images[index - 1]))
                using (var img = Image.FromStream(ms))
                {
                    pictureBoxView.Image = (Image)img.Clone();
                    ImageTracker.Track(pictureBoxView.Image);
                }

                pictureBoxView.SizeMode = (pictureBoxView.Image.Width > pictureBoxView.ClientSize.Width ||
                                           pictureBoxView.Image.Height > pictureBoxView.ClientSize.Height)
                                           ? PictureBoxSizeMode.Zoom
                                           : checkBoxViewOrignianResolution.Checked
                                             ? PictureBoxSizeMode.CenterImage
                                             : PictureBoxSizeMode.Zoom;

                textBoxViewCurrentImage.Text = index.ToString();
                tableLayoutPanelViewControll.BackColor = Color.White;
                tabPageView.BackColor = Color.White;
            }
            catch
            {
                if (pictureBoxView.Image != null)
                {
                    pictureBoxView.Image.Dispose();
                    pictureBoxView.Image = null;
                }

                pictureBoxView.Image = pictureBoxView.ErrorImage;
                ImageTracker.Track(pictureBoxView.Image);
                tableLayoutPanelViewControll.BackColor = Color.Red;
                tabPageView.BackColor = Color.Red;
                textBoxViewCurrentImage.Text = index.ToString();
            }
        }
        private void buttonViewPrevious_Click(object sender, EventArgs e)
        {
            CurrentViewImageIndex--;
        }

        private void buttonViewNext_Click(object sender, EventArgs e)
        {
            CurrentViewImageIndex++;
        }
        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab != tabPageView)
            {
                if (pictureBoxView.Image != null)
                {
                    pictureBoxView.Image.Dispose();
                    pictureBoxView.Image = null;
                }
            }
        }
    }
}
