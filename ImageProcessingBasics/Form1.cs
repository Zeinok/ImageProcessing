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
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() != DialogResult.OK) return;
            appendLog(String.Format("Opening file {0}...",ofd.SafeFileName));
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            pictureBoxIn.Image = Image.FromStream(fs);
            pictureBoxOut.Image = Image.FromStream(fs);
            inputBitmap = (Bitmap)pictureBoxIn.Image;
            outputBitmap = (Bitmap)pictureBoxOut.Image;
            fs.Close();
            appendLog(String.Format("File {0} opened.", ofd.SafeFileName));
            updateInputRGBGraph();
            updateOutputRGBGraph();

            GC.Collect();
        }

        private void updateInputRGBGraph()
        {
            Bitmap[] rgbGraph = Graph.getRGBGraph(inputBitmap);
            pictureBoxInR.Image = rgbGraph[0];
            pictureBoxInG.Image = rgbGraph[1];
            pictureBoxInB.Image = rgbGraph[2];

        }

        private void updateOutputRGBGraph()
        {
            Bitmap[] rgbGraph = Graph.getRGBGraph(outputBitmap);
            pictureBoxOutR.Image = rgbGraph[0];
            pictureBoxOutG.Image = rgbGraph[1];
            pictureBoxOutB.Image = rgbGraph[2];

        }

        private void appendLog(string msg)
        {
            listBoxLog.Items.Add(msg);
        }

    }
}
