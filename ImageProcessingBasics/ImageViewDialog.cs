using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcessingBasics
{
    public partial class ImageViewDialog : Form
    {
        double scale = 1;
        bool holdingCtrl = false;
        public ImageViewDialog(Image image) {
            InitializeComponent();
            pictureBox.Image = image;
            pictureBox.Size = image.Size;
            centerPictureBox();
            this.MouseWheel += new MouseEventHandler(ImageViewDialog_MouseWheel);
        }

        private void ImageViewDialog_KeyUp(object sender, KeyEventArgs e) {
            holdingCtrl = false;

        }

        private void ImageViewDialog_KeyDown(object sender, KeyEventArgs e) {
            holdingCtrl = e.Control;
        }

        private void ImageViewDialog_MouseWheel(object sender, MouseEventArgs e) {
            if(holdingCtrl) {
                if(e.Delta > 0) {
                    scale *= 2;
                } else {
                    scale /= 2;
                }
                pictureBox.Location = new Point();
                pictureBox.Size = new Size((int)(pictureBox.Image.Width * scale), (int)(pictureBox.Image.Height * scale));
                
            }
        }

        private void pictureBox_SizeChanged(object sender, EventArgs e) {
            centerPictureBox();
        }

        private void ImageViewDialog_SizeChanged(object sender, EventArgs e) {
            centerPictureBox();
        }

        private void centerPictureBox() {
            int x = this.ClientSize.Width / 2 - pictureBox.Width / 2;
            int y = this.ClientSize.Height / 2 - pictureBox.Height / 2;
            if(x < 0) x = 0;
            if(y < 0) y = 0;
            pictureBox.Location = new Point(x, y);
        }
    }
}