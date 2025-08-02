using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrImage
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
            if (checkBoxViewOrignianResolution.Checked)
            {
                pictureBoxView.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                pictureBoxView.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void textBoxViewCurrentImage_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxViewCurrentImage.Text))
            {
                return;
            }
            try
            {
                int index = int.Parse(textBoxViewCurrentImage.Text);
                if (index < 1 || index > Images.Count)
                {
                    throw new ArgumentOutOfRangeException("Index out of range");
                }
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
                using (var ms = new System.IO.MemoryStream(Images[index - 1]))
                {
                    pictureBoxView.Image = System.Drawing.Image.FromStream(ms);
                    if(pictureBoxView.Image.Size.Width > pictureBoxView.ClientSize.Width || pictureBoxView.Image.Size.Height > pictureBoxView.ClientSize.Height)
                    {
                        pictureBoxView.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else if (checkBoxViewOrignianResolution.Checked)
                    {
                        pictureBoxView.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    else
                    {
                        pictureBoxView.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                textBoxViewCurrentImage.Text = index.ToString();
                tableLayoutPanelViewControll.BackColor = System.Drawing.Color.White;
                tabPageView.BackColor = System.Drawing.Color.White;
            }
            catch
            {
                pictureBoxView.Image = pictureBoxView.ErrorImage;
                tableLayoutPanelViewControll.BackColor = System.Drawing.Color.Red;
                tabPageView.BackColor = System.Drawing.Color.Red;
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
    }
}
