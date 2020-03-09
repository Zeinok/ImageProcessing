using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageProcessingBasics
{
    public partial class Form1 : Form
    {
        string fileDialogImageFilter = Helper.GetImageFileFilter();

        Bitmap inputBitmap {
            get
            {
                return _inputBitmap;
            }
            set
            {
                _inputBitmap = value;
            }
        }
        Bitmap _inputBitmap = null;
        Bitmap outputBitmap
        {
            get
            {
                return _outputBitmap;
            }
            set
            {
                _outputBitmap = value;
            }
        }
        Bitmap _outputBitmap = null;
        string saveFilename = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = fileDialogImageFilter;
                if (ofd.ShowDialog() != DialogResult.OK) return;
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                inputBitmap = (Bitmap)Image.FromStream(fs);
                outputBitmap = (Bitmap)Image.FromStream(fs);
                fs.Close();
                appendLog(String.Format("File {0} opened.", ofd.SafeFileName));

                AsyncWrapper.Wrap(updateInputRGBGraph());
                AsyncWrapper.Wrap(updateOutputRGBGraph());
            }
            catch (Exception ex)
            {
                appendLog(String.Format("Exception occured during opening file: {0}", ex.Message));
            }

            GC.Collect();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFilename == "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = fileDialogImageFilter;
                sfd.DefaultExt = "*.png";
                if (sfd.ShowDialog() != DialogResult.OK) return;
                saveFilename = sfd.FileName;
            }
            
            try
            {
                FileStream fs = new FileStream(saveFilename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
                pictureBoxOut.Image.Save(fs, Helper.GetImageFormat(saveFilename));
                fs.Close();
                appendLog("Done saving image.");
            }
            catch (Exception ex)
            {
                appendLog(String.Format("Failed to write file: {0}", ex.Message));
            }
            
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFilename = "";
            saveToolStripMenuItem.PerformClick();
        }

        private async Task updateInputRGBGraph()
        {
            Bitmap[] rgbGraph = await Task<Bitmap[]>.Factory.StartNew(() => Graph.GetRGBGraph(Helper.deepCloneBMP(inputBitmap)));
            pictureBoxInR.Image = rgbGraph[0];
            pictureBoxInG.Image = rgbGraph[1];
            pictureBoxInB.Image = rgbGraph[2];
            this.Invalidate();
            
        }

        private async Task updateOutputRGBGraph()
        {
            Bitmap[] rgbGraph = await Task<Bitmap[]>.Factory.StartNew(() => Graph.GetRGBGraph(Helper.deepCloneBMP(outputBitmap)));
            pictureBoxOutR.Image = rgbGraph[0];
            pictureBoxOutG.Image = rgbGraph[1];
            pictureBoxOutB.Image = rgbGraph[2];
            this.Invalidate();
        }

        delegate void appendLogDelegator(string msg);
        public void appendLog(string msg)
        {
            if (listBoxLog.InvokeRequired)
            {
                appendLogDelegator dlgt = new appendLogDelegator(appendLog);
                this.Invoke(dlgt, new object[] { msg });
                return;
            } 
            listBoxLog.Items.Add(msg);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (inputBitmap != null)
            {
                pictureBoxIn.Image = Helper.deepCloneBMP(inputBitmap);
                labelInImgSize.Text = String.Format("{0}x{1}", inputBitmap.Width, inputBitmap.Height);
            }
            if (outputBitmap != null)
            {
                pictureBoxOut.Image = Helper.deepCloneBMP(outputBitmap);
                labelOutImgSize.Text = String.Format("{0}x{1}", outputBitmap.Width, outputBitmap.Height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GC.Collect();
        }
    }
}
