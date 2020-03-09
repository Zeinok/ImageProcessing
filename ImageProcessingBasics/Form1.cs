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
        Bitmap inputBitmap = null;
        Bitmap outputBitmap = null;
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
                ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
                if (ofd.ShowDialog() != DialogResult.OK) return;
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                //pictureBoxIn.Image = Image.FromStream(fs);
                //pictureBoxOut.Image = Image.FromStream(fs);
                inputBitmap = (Bitmap)Image.FromStream(fs);
                outputBitmap = (Bitmap)Image.FromStream(fs);
                fs.Close();
                appendLog(String.Format("File {0} opened.", ofd.SafeFileName));

                AsnycWrapper(updateInputRGBGraph());
                AsnycWrapper(updateOutputRGBGraph());
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
                saveAsToolStripMenuItem.PerformClick();
            
            if (saveFilename != "") //alright user filled filename let's do it
            {
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
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK) saveFilename = sfd.FileName;

        }

        private Bitmap deepCloneBMP(Bitmap bmp)
        {
            
            return new Bitmap(bmp.Clone(new Rectangle(new Point(), bmp.Size), bmp.PixelFormat), bmp.Size);
        }
        private async Task updateInputRGBGraph()
        {
            Bitmap[] rgbGraph = await Task<Bitmap[]>.Factory.StartNew(() => Graph.GetRGBGraph(deepCloneBMP(inputBitmap)));
            pictureBoxInR.Image = rgbGraph[0];
            pictureBoxInG.Image = rgbGraph[1];
            pictureBoxInB.Image = rgbGraph[2];
            this.Invalidate();
            
        }

        private async Task updateOutputRGBGraph()
        {
            Bitmap[] rgbGraph = await Task<Bitmap[]>.Factory.StartNew(() => Graph.GetRGBGraph(deepCloneBMP(outputBitmap)));
            pictureBoxOutR.Image = rgbGraph[0];
            pictureBoxOutG.Image = rgbGraph[1];
            pictureBoxOutB.Image = rgbGraph[2];
            this.Invalidate();
        }

        private void AsnycWrapper(Task task)
        {
            var fieldInfo = typeof(Task).GetField("m_action", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            Action action = (Action)fieldInfo.GetValue(task);
            task.ContinueWith((t) => {
                if (t.Exception != null)
                {
                    appendLog("Async wrapper faulted with exception:");
                    t.Exception.ToString().Split(new char[] { '\n' }).ToList().ForEach(s => appendLog(s));
                }
                else appendLog("Async wrapper faulted without exception.");

        }, TaskContinuationOptions.OnlyOnFaulted);
        }

        delegate void appendLogDelegator(string msg);
        private void appendLog(string msg)
        {
            if (listBoxLog.InvokeRequired)
            {
                appendLogDelegator dlgt = new appendLogDelegator(appendLog);
                this.Invoke(dlgt, new object[] { msg });
            } else listBoxLog.Items.Add(msg);

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (inputBitmap != null)
            {
                pictureBoxIn.Image = deepCloneBMP(inputBitmap);
                labelInImgSize.Text = String.Format("{0}x{1}", inputBitmap.Width, inputBitmap.Height);
            }
            if (outputBitmap != null)
            {
                pictureBoxOut.Image = deepCloneBMP(outputBitmap);
                labelOutImgSize.Text = String.Format("{0}x{1}", outputBitmap.Width, outputBitmap.Height);
            }
        }

    }
}
