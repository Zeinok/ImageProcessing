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
using System.IO.MemoryMappedFiles;

using System.Diagnostics;

namespace ImageProcessingBasics
{
    public partial class Form1 : Form
    {
        string fileDialogImageFilter = Helper.GetImageFileFilter();
        PictureBox[] pictureBoxes = null;
        PictureBox[] outputPictureBoxes = null;
        Stack<Bitmap> undo = new Stack<Bitmap>();
        Stack<Bitmap> redo = new Stack<Bitmap>();

        Bitmap inputBitmap {
            get
            {
                return _inputBitmap;
            }
            set
            {
                inputBitmapChanged = true;
                _inputBitmap = value;
            }
        }
        bool inputBitmapChanged = false;
        Bitmap _inputBitmap = null;
        Bitmap outputBitmap
        {
            get
            {
                return _outputBitmap;
            }
            set
            {
                outputBitmapChanged = true;
                _outputBitmap = value;
            }
        }
        bool outputBitmapChanged = false;
        Bitmap _outputBitmap = null;
        string saveFilename = "";

        public Form1()
        {
            InitializeComponent();
        }
        
        private async Task<bool> loadImg(Stream s)
        {

            //byte[] imgBuffer = new byte[s.Length];
            //s.Write(imgBuffer, 0, (int)s.Length);
            //s.Close();
            //MemoryStream ms = new MemoryStream(imgBuffer, true);
            //ms.Write(imgBuffer, 0, imgBuffer.Length);

            inputBitmap = new Bitmap(s);
            outputBitmap = new Bitmap(s);
            s.Close();
            await updateAllRGBGraph();
            return true;
        }
        private async Task<bool> updateAllRGBGraph()
        {
            await updateInputRGBGraph();
            await updateOutputRGBGraph();
            return true;
        }
        private async Task updateInputRGBGraph()
        {
            Bitmap[] rgbGraph = await Task<Bitmap[]>.Factory.StartNew(() => Graph.GetRGBGraph(Helper.deepCloneBMP(inputBitmap)));
            GC.Collect();
            pictureBoxInRGraph.Image = rgbGraph[0];
            pictureBoxInGGraph.Image = rgbGraph[1];
            pictureBoxInBGraph.Image = rgbGraph[2];
            pictureBoxInRonly.Image = await AsyncWrapper.Wrap(() => Graph.GetRGBImage(Helper.deepCloneBMP(inputBitmap), Graph.Color.R));
            pictureBoxInGonly.Image = await AsyncWrapper.Wrap(() => Graph.GetRGBImage(Helper.deepCloneBMP(inputBitmap), Graph.Color.G));
            pictureBoxInBonly.Image = await AsyncWrapper.Wrap(() => Graph.GetRGBImage(Helper.deepCloneBMP(inputBitmap), Graph.Color.B));

            this.Invalidate();
            
        }

        private async Task updateOutputRGBGraph()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Bitmap[] rgbGraph = await Task<Bitmap[]>.Factory.StartNew(() => Graph.GetRGBGraph(Helper.deepCloneBMP(outputBitmap)));
            GC.Collect();
            pictureBoxOutRGraph.Image = rgbGraph[0];
            pictureBoxOutGGraph.Image = rgbGraph[1];
            pictureBoxOutBGraph.Image = rgbGraph[2];
            GC.Collect();
            pictureBoxOutRonly.Image = await AsyncWrapper.Wrap(() => Graph.GetRGBImage(Helper.deepCloneBMP(outputBitmap), Graph.Color.R));
            GC.Collect();
            pictureBoxOutGonly.Image = await AsyncWrapper.Wrap(() => Graph.GetRGBImage(Helper.deepCloneBMP(outputBitmap), Graph.Color.G));
            GC.Collect();
            pictureBoxOutBonly.Image = await AsyncWrapper.Wrap(() => Graph.GetRGBImage(Helper.deepCloneBMP(outputBitmap), Graph.Color.B));
            GC.Collect();
            this.Invalidate();
            sw.Stop();
            appendLog(String.Format("updateOutputRGBGraph(): {0}ms", sw.ElapsedMilliseconds));
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
            listBoxLog.SelectedIndex = listBoxLog.Items.Count - 1;
            listBoxLog.SelectedItem = null;

        }
        private void clearOutput()
        {
            foreach(var p in outputPictureBoxes)
            {
                p.Image = null;
            }
        }
        private void pushChange(Bitmap change)
        {
            undo.Push(change);
            redo.Clear();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (inputBitmap != null && inputBitmapChanged)
            {
                inputBitmapChanged = false;
                pictureBoxIn.Image = inputBitmap;
                labelInImgSize.Text = String.Format("{0}x{1}", inputBitmap.Width, inputBitmap.Height);
            }
            GC.Collect();
            if (outputBitmap != null && outputBitmapChanged)
            {
                outputBitmapChanged = false;
                pictureBoxOut.Image = outputBitmap;
                labelOutImgSize.Text = String.Format("{0}x{1}", outputBitmap.Width, outputBitmap.Height);
            }
            GC.Collect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBoxes = new PictureBox[] { 
                pictureBoxIn, pictureBoxInRGraph, pictureBoxInGGraph, pictureBoxInBGraph, 
                pictureBoxOut, pictureBoxOutRGraph, pictureBoxOutGGraph, pictureBoxOutBGraph, 
                pictureBoxInRonly, pictureBoxInGonly, pictureBoxInBonly,
                pictureBoxOutRonly, pictureBoxOutGonly, pictureBoxOutBonly
            };
            outputPictureBoxes = new PictureBox[] {
                pictureBoxOut, pictureBoxOutRGraph, pictureBoxOutGGraph, pictureBoxOutBGraph,
                pictureBoxOutRonly, pictureBoxOutGonly, pictureBoxOutBonly
            };
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //try
            //{
            GC.AddMemoryPressure(256);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = fileDialogImageFilter;
            if (ofd.ShowDialog() != DialogResult.OK) return;
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            foreach (var p in pictureBoxes)
                p.Image = null;
            AsyncWrapper.WrapSync(loadImg(fs));
            //fs.Close();
            appendLog(String.Format("File {0} opened.", ofd.SafeFileName));



            GC.Collect();
            undo.Clear();
            redo.Clear();

            //            }
            //            catch (Exception ex)
            //            {
            //                appendLog(String.Format("Exception occured during opening file: {0}", ex.Message));
            //#if DEBUG
            //                throw ex;
            //#endif
            //            }
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
                appendLog(String.Format("Saved image to {0}.", saveFilename));
            }
            catch (Exception ex)
            {
                appendLog(String.Format("Failed to write file to {0}: {1}", saveFilename, ex.Message));
            }

        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFilename = "";
            saveToolStripMenuItem.PerformClick();
        }
        private void toolStripDropDownButtonEdit_DropDownOpening(object sender, EventArgs e)
        {
            undoToolStripMenuItem.Enabled = undo.Count != 0;
            redoToolStripMenuItem.Enabled = redo.Count != 0;
        }
        private async void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undo.Count > 0)
            {
                redo.Push(outputBitmap);
                outputBitmap = undo.Pop();
                await updateOutputRGBGraph();
            }
            else MessageBox.Show("Nothing to undo");
        }
        private async void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (redo.Count > 0)
            {
                undo.Push(outputBitmap);
                outputBitmap = redo.Pop();
                await updateOutputRGBGraph();
            }
            else MessageBox.Show("Nothing to redo");
        }
        private async void buttonGrayscaleMeanWeight_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            clearOutput();
            pushChange(Helper.deepCloneBMP(outputBitmap));
            outputBitmap = await AsyncWrapper.Wrap(() => Grayscale.MeanWeight(Helper.deepCloneBMP(outputBitmap)));
            sw.Stop();
            appendLog(String.Format("buttonGrayscaleMeanWeight_Click(): {0}ms", sw.ElapsedMilliseconds));
            await updateOutputRGBGraph();
        }

        private async void buttonGrayscaleMeanValue_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            clearOutput();
            pushChange(Helper.deepCloneBMP(outputBitmap));
            outputBitmap = await AsyncWrapper.Wrap(() => Grayscale.MeanValue(Helper.deepCloneBMP(outputBitmap)));
            sw.Stop();
            appendLog(String.Format("buttonGrayscaleMeanValue_Click(): {0}ms", sw.ElapsedMilliseconds));
            await updateOutputRGBGraph();
        }

        private async void buttonMaximum_Click(object sender, EventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            clearOutput();
            pushChange(Helper.deepCloneBMP(outputBitmap));
            outputBitmap = await AsyncWrapper.Wrap(() => Grayscale.Max(Helper.deepCloneBMP(outputBitmap)));
            sw.Stop();
            appendLog(String.Format("buttonMaximum_Click(): {0}ms", sw.ElapsedMilliseconds));
            await updateOutputRGBGraph();
            
        }


    }
}
