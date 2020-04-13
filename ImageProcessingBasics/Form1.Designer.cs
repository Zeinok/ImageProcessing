namespace ImageProcessingBasics
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxIn = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButtonEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.labelInB = new System.Windows.Forms.Label();
            this.labelInG = new System.Windows.Forms.Label();
            this.labelInR = new System.Windows.Forms.Label();
            this.pictureBoxInBonly = new System.Windows.Forms.PictureBox();
            this.pictureBoxInGonly = new System.Windows.Forms.PictureBox();
            this.pictureBoxInRonly = new System.Windows.Forms.PictureBox();
            this.labelInImgSize = new System.Windows.Forms.Label();
            this.pictureBoxInBGraph = new System.Windows.Forms.PictureBox();
            this.pictureBoxInGGraph = new System.Windows.Forms.PictureBox();
            this.pictureBoxInRGraph = new System.Windows.Forms.PictureBox();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.labelB = new System.Windows.Forms.Label();
            this.pictureBoxOutBonly = new System.Windows.Forms.PictureBox();
            this.labelOutG = new System.Windows.Forms.Label();
            this.pictureBoxOutGonly = new System.Windows.Forms.PictureBox();
            this.labelOutR = new System.Windows.Forms.Label();
            this.pictureBoxOutRonly = new System.Windows.Forms.PictureBox();
            this.labelOutImgSize = new System.Windows.Forms.Label();
            this.pictureBoxOutBGraph = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutGGraph = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutRGraph = new System.Windows.Forms.PictureBox();
            this.pictureBoxOut = new System.Windows.Forms.PictureBox();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBoxManipulation = new System.Windows.Forms.GroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBoxCompression = new System.Windows.Forms.GroupBox();
            this.textBoxCompressionBits = new System.Windows.Forms.TextBox();
            this.labelCompressionBits = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBoxSegmentation = new System.Windows.Forms.GroupBox();
            this.textBoxIterationLevel = new System.Windows.Forms.TextBox();
            this.textBoxSegmentationK = new System.Windows.Forms.TextBox();
            this.labelSegmentationIterationLevel = new System.Windows.Forms.Label();
            this.labelSegmentationK = new System.Windows.Forms.Label();
            this.buttonSegmentationKmeans = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBoxEncryption = new System.Windows.Forms.GroupBox();
            this.textBoxEncryptionKey = new System.Windows.Forms.TextBox();
            this.ButtonEncryptionClear = new System.Windows.Forms.Button();
            this.ButtonEncryptionDecrypt = new System.Windows.Forms.Button();
            this.buttonEncryptionEncrypt = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBoxMorphology = new System.Windows.Forms.GroupBox();
            this.buttonMorphlogyClosing = new System.Windows.Forms.Button();
            this.buttonMorphologyOpening = new System.Windows.Forms.Button();
            this.buttonMorphologyDilation = new System.Windows.Forms.Button();
            this.buttonMorphologyErosion = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxSpaceFilter = new System.Windows.Forms.GroupBox();
            this.buttonSpaceFilterKirsch = new System.Windows.Forms.Button();
            this.buttonSpaceFilterLaplacian = new System.Windows.Forms.Button();
            this.buttonSpaceFilterSobel = new System.Windows.Forms.Button();
            this.buttonSpaceFilterMean = new System.Windows.Forms.Button();
            this.buttonSpaceFilterMedium = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxContrast = new System.Windows.Forms.GroupBox();
            this.buttonPowerLaw = new System.Windows.Forms.Button();
            this.buttonContrastLogarithmic = new System.Windows.Forms.Button();
            this.buttonContrastNegative = new System.Windows.Forms.Button();
            this.buttonContrastSharpening = new System.Windows.Forms.Button();
            this.buttonContrastHistogramEqualization = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxBrightness = new System.Windows.Forms.GroupBox();
            this.buttonBrightnessDarken = new System.Windows.Forms.Button();
            this.buttonBrightnessBrighten = new System.Windows.Forms.Button();
            this.groupBoxThresholding = new System.Windows.Forms.GroupBox();
            this.buttonThresholdingOtsuMethod = new System.Windows.Forms.Button();
            this.groupBoxGrayscale = new System.Windows.Forms.GroupBox();
            this.buttonMaximum = new System.Windows.Forms.Button();
            this.buttonGrayscaleMeanValue = new System.Windows.Forms.Button();
            this.buttonGrayscaleMeanWeight = new System.Windows.Forms.Button();
            this.buttonTransformReverse = new System.Windows.Forms.Button();
            this.groupBoxResize = new System.Windows.Forms.GroupBox();
            this.buttonDoResize = new System.Windows.Forms.Button();
            this.textBoxResizeHeight = new System.Windows.Forms.TextBox();
            this.labelResizeHeight = new System.Windows.Forms.Label();
            this.textBoxResizeX = new System.Windows.Forms.TextBox();
            this.labelResizeWidth = new System.Windows.Forms.Label();
            this.buttonTransformOrigin = new System.Windows.Forms.Button();
            this.timerEnableControl = new System.Windows.Forms.Timer(this.components);
            this.buttonSpaceFilterMin = new System.Windows.Forms.Button();
            this.buttonSpaceFilterMax = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInBonly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInGonly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInRonly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInBGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInGGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInRGraph)).BeginInit();
            this.groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutBonly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutGonly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutRonly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutBGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutGGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutRGraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).BeginInit();
            this.groupBoxLog.SuspendLayout();
            this.groupBoxManipulation.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBoxCompression.SuspendLayout();
            this.panel6.SuspendLayout();
            this.groupBoxSegmentation.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBoxEncryption.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxMorphology.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxSpaceFilter.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBoxContrast.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxBrightness.SuspendLayout();
            this.groupBoxThresholding.SuspendLayout();
            this.groupBoxGrayscale.SuspendLayout();
            this.groupBoxResize.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxIn
            // 
            this.pictureBoxIn.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxIn.Name = "pictureBoxIn";
            this.pictureBoxIn.Size = new System.Drawing.Size(320, 320);
            this.pictureBoxIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxIn.TabIndex = 0;
            this.pictureBoxIn.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile,
            this.toolStripDropDownButtonEdit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1434, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonFile
            // 
            this.toolStripDropDownButtonFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.toolStripDropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFile.Image")));
            this.toolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile.Name = "toolStripDropDownButtonFile";
            this.toolStripDropDownButtonFile.Size = new System.Drawing.Size(57, 22);
            this.toolStripDropDownButtonFile.Text = "File (&F)";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.openToolStripMenuItem.Text = "Open (&O)";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveToolStripMenuItem.Text = "Save (&S)";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.saveAsToolStripMenuItem.Text = "Save As (&A)";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripDropDownButtonEdit
            // 
            this.toolStripDropDownButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButtonEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.toolStripDropDownButtonEdit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonEdit.Image")));
            this.toolStripDropDownButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonEdit.Name = "toolStripDropDownButtonEdit";
            this.toolStripDropDownButtonEdit.Size = new System.Drawing.Size(61, 22);
            this.toolStripDropDownButtonEdit.Text = "Edit (&E)";
            this.toolStripDropDownButtonEdit.DropDownOpening += new System.EventHandler(this.toolStripDropDownButtonEdit_DropDownOpening);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.undoToolStripMenuItem.Text = "Undo (&Z)";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.redoToolStripMenuItem.Text = "Redo (&Y)";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Controls.Add(this.labelInB);
            this.groupBoxIn.Controls.Add(this.labelInG);
            this.groupBoxIn.Controls.Add(this.labelInR);
            this.groupBoxIn.Controls.Add(this.pictureBoxInBonly);
            this.groupBoxIn.Controls.Add(this.pictureBoxInGonly);
            this.groupBoxIn.Controls.Add(this.pictureBoxInRonly);
            this.groupBoxIn.Controls.Add(this.labelInImgSize);
            this.groupBoxIn.Controls.Add(this.pictureBoxInBGraph);
            this.groupBoxIn.Controls.Add(this.pictureBoxInGGraph);
            this.groupBoxIn.Controls.Add(this.pictureBoxInRGraph);
            this.groupBoxIn.Controls.Add(this.pictureBoxIn);
            this.groupBoxIn.Location = new System.Drawing.Point(12, 28);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(332, 565);
            this.groupBoxIn.TabIndex = 3;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "Original Image";
            // 
            // labelInB
            // 
            this.labelInB.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelInB.ForeColor = System.Drawing.Color.Blue;
            this.labelInB.Location = new System.Drawing.Point(218, 344);
            this.labelInB.Name = "labelInB";
            this.labelInB.Size = new System.Drawing.Size(100, 26);
            this.labelInB.TabIndex = 10;
            this.labelInB.Text = "B";
            this.labelInB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInG
            // 
            this.labelInG.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelInG.ForeColor = System.Drawing.Color.Green;
            this.labelInG.Location = new System.Drawing.Point(112, 344);
            this.labelInG.Name = "labelInG";
            this.labelInG.Size = new System.Drawing.Size(100, 26);
            this.labelInG.TabIndex = 9;
            this.labelInG.Text = "G";
            this.labelInG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInR
            // 
            this.labelInR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelInR.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelInR.ForeColor = System.Drawing.Color.Red;
            this.labelInR.Location = new System.Drawing.Point(6, 344);
            this.labelInR.Name = "labelInR";
            this.labelInR.Size = new System.Drawing.Size(100, 26);
            this.labelInR.TabIndex = 8;
            this.labelInR.Text = "R";
            this.labelInR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxInBonly
            // 
            this.pictureBoxInBonly.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxInBonly.Location = new System.Drawing.Point(218, 373);
            this.pictureBoxInBonly.Name = "pictureBoxInBonly";
            this.pictureBoxInBonly.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxInBonly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInBonly.TabIndex = 7;
            this.pictureBoxInBonly.TabStop = false;
            // 
            // pictureBoxInGonly
            // 
            this.pictureBoxInGonly.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxInGonly.Location = new System.Drawing.Point(112, 373);
            this.pictureBoxInGonly.Name = "pictureBoxInGonly";
            this.pictureBoxInGonly.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxInGonly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInGonly.TabIndex = 6;
            this.pictureBoxInGonly.TabStop = false;
            // 
            // pictureBoxInRonly
            // 
            this.pictureBoxInRonly.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxInRonly.Location = new System.Drawing.Point(6, 373);
            this.pictureBoxInRonly.Name = "pictureBoxInRonly";
            this.pictureBoxInRonly.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxInRonly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxInRonly.TabIndex = 5;
            this.pictureBoxInRonly.TabStop = false;
            // 
            // labelInImgSize
            // 
            this.labelInImgSize.AutoSize = true;
            this.labelInImgSize.Location = new System.Drawing.Point(110, 0);
            this.labelInImgSize.Name = "labelInImgSize";
            this.labelInImgSize.Size = new System.Drawing.Size(21, 12);
            this.labelInImgSize.TabIndex = 4;
            this.labelInImgSize.Text = "?x?";
            this.labelInImgSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBoxInBGraph
            // 
            this.pictureBoxInBGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxInBGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInBGraph.Location = new System.Drawing.Point(218, 479);
            this.pictureBoxInBGraph.Name = "pictureBoxInBGraph";
            this.pictureBoxInBGraph.Size = new System.Drawing.Size(100, 80);
            this.pictureBoxInBGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInBGraph.TabIndex = 3;
            this.pictureBoxInBGraph.TabStop = false;
            // 
            // pictureBoxInGGraph
            // 
            this.pictureBoxInGGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxInGGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInGGraph.Location = new System.Drawing.Point(112, 479);
            this.pictureBoxInGGraph.Name = "pictureBoxInGGraph";
            this.pictureBoxInGGraph.Size = new System.Drawing.Size(100, 80);
            this.pictureBoxInGGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInGGraph.TabIndex = 2;
            this.pictureBoxInGGraph.TabStop = false;
            // 
            // pictureBoxInRGraph
            // 
            this.pictureBoxInRGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxInRGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxInRGraph.Location = new System.Drawing.Point(6, 479);
            this.pictureBoxInRGraph.Name = "pictureBoxInRGraph";
            this.pictureBoxInRGraph.Size = new System.Drawing.Size(100, 80);
            this.pictureBoxInRGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxInRGraph.TabIndex = 1;
            this.pictureBoxInRGraph.TabStop = false;
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Controls.Add(this.labelB);
            this.groupBoxOut.Controls.Add(this.pictureBoxOutBonly);
            this.groupBoxOut.Controls.Add(this.labelOutG);
            this.groupBoxOut.Controls.Add(this.pictureBoxOutGonly);
            this.groupBoxOut.Controls.Add(this.labelOutR);
            this.groupBoxOut.Controls.Add(this.pictureBoxOutRonly);
            this.groupBoxOut.Controls.Add(this.labelOutImgSize);
            this.groupBoxOut.Controls.Add(this.pictureBoxOutBGraph);
            this.groupBoxOut.Controls.Add(this.pictureBoxOutGGraph);
            this.groupBoxOut.Controls.Add(this.pictureBoxOutRGraph);
            this.groupBoxOut.Controls.Add(this.pictureBoxOut);
            this.groupBoxOut.Location = new System.Drawing.Point(350, 28);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(332, 565);
            this.groupBoxOut.TabIndex = 4;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Result Image";
            // 
            // labelB
            // 
            this.labelB.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelB.ForeColor = System.Drawing.Color.Blue;
            this.labelB.Location = new System.Drawing.Point(218, 344);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(100, 26);
            this.labelB.TabIndex = 10;
            this.labelB.Text = "B";
            this.labelB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxOutBonly
            // 
            this.pictureBoxOutBonly.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxOutBonly.Location = new System.Drawing.Point(218, 373);
            this.pictureBoxOutBonly.Name = "pictureBoxOutBonly";
            this.pictureBoxOutBonly.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxOutBonly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOutBonly.TabIndex = 8;
            this.pictureBoxOutBonly.TabStop = false;
            // 
            // labelOutG
            // 
            this.labelOutG.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOutG.ForeColor = System.Drawing.Color.Green;
            this.labelOutG.Location = new System.Drawing.Point(112, 344);
            this.labelOutG.Name = "labelOutG";
            this.labelOutG.Size = new System.Drawing.Size(100, 26);
            this.labelOutG.TabIndex = 9;
            this.labelOutG.Text = "G";
            this.labelOutG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxOutGonly
            // 
            this.pictureBoxOutGonly.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxOutGonly.Location = new System.Drawing.Point(112, 373);
            this.pictureBoxOutGonly.Name = "pictureBoxOutGonly";
            this.pictureBoxOutGonly.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxOutGonly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOutGonly.TabIndex = 7;
            this.pictureBoxOutGonly.TabStop = false;
            // 
            // labelOutR
            // 
            this.labelOutR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOutR.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labelOutR.ForeColor = System.Drawing.Color.Red;
            this.labelOutR.Location = new System.Drawing.Point(6, 344);
            this.labelOutR.Name = "labelOutR";
            this.labelOutR.Size = new System.Drawing.Size(100, 26);
            this.labelOutR.TabIndex = 8;
            this.labelOutR.Text = "R";
            this.labelOutR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxOutRonly
            // 
            this.pictureBoxOutRonly.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxOutRonly.Location = new System.Drawing.Point(6, 373);
            this.pictureBoxOutRonly.Name = "pictureBoxOutRonly";
            this.pictureBoxOutRonly.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxOutRonly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOutRonly.TabIndex = 6;
            this.pictureBoxOutRonly.TabStop = false;
            // 
            // labelOutImgSize
            // 
            this.labelOutImgSize.AutoSize = true;
            this.labelOutImgSize.Location = new System.Drawing.Point(110, 0);
            this.labelOutImgSize.Name = "labelOutImgSize";
            this.labelOutImgSize.Size = new System.Drawing.Size(21, 12);
            this.labelOutImgSize.TabIndex = 5;
            this.labelOutImgSize.Text = "?x?";
            this.labelOutImgSize.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pictureBoxOutBGraph
            // 
            this.pictureBoxOutBGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxOutBGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOutBGraph.Location = new System.Drawing.Point(218, 479);
            this.pictureBoxOutBGraph.Name = "pictureBoxOutBGraph";
            this.pictureBoxOutBGraph.Size = new System.Drawing.Size(100, 80);
            this.pictureBoxOutBGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOutBGraph.TabIndex = 3;
            this.pictureBoxOutBGraph.TabStop = false;
            // 
            // pictureBoxOutGGraph
            // 
            this.pictureBoxOutGGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxOutGGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOutGGraph.Location = new System.Drawing.Point(112, 479);
            this.pictureBoxOutGGraph.Name = "pictureBoxOutGGraph";
            this.pictureBoxOutGGraph.Size = new System.Drawing.Size(100, 80);
            this.pictureBoxOutGGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOutGGraph.TabIndex = 2;
            this.pictureBoxOutGGraph.TabStop = false;
            // 
            // pictureBoxOutRGraph
            // 
            this.pictureBoxOutRGraph.BackColor = System.Drawing.Color.White;
            this.pictureBoxOutRGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOutRGraph.Location = new System.Drawing.Point(6, 479);
            this.pictureBoxOutRGraph.Name = "pictureBoxOutRGraph";
            this.pictureBoxOutRGraph.Size = new System.Drawing.Size(100, 80);
            this.pictureBoxOutRGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOutRGraph.TabIndex = 1;
            this.pictureBoxOutRGraph.TabStop = false;
            // 
            // pictureBoxOut
            // 
            this.pictureBoxOut.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxOut.Name = "pictureBoxOut";
            this.pictureBoxOut.Size = new System.Drawing.Size(320, 320);
            this.pictureBoxOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOut.TabIndex = 0;
            this.pictureBoxOut.TabStop = false;
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.listBoxLog);
            this.groupBoxLog.Location = new System.Drawing.Point(12, 599);
            this.groupBoxLog.Name = "groupBoxLog";
            this.groupBoxLog.Size = new System.Drawing.Size(670, 150);
            this.groupBoxLog.TabIndex = 5;
            this.groupBoxLog.TabStop = false;
            this.groupBoxLog.Text = "Logs";
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 12;
            this.listBoxLog.Location = new System.Drawing.Point(6, 21);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.ScrollAlwaysVisible = true;
            this.listBoxLog.Size = new System.Drawing.Size(658, 124);
            this.listBoxLog.TabIndex = 0;
            // 
            // groupBoxManipulation
            // 
            this.groupBoxManipulation.Controls.Add(this.panel7);
            this.groupBoxManipulation.Controls.Add(this.panel6);
            this.groupBoxManipulation.Controls.Add(this.panel5);
            this.groupBoxManipulation.Controls.Add(this.panel4);
            this.groupBoxManipulation.Controls.Add(this.panel3);
            this.groupBoxManipulation.Controls.Add(this.panel2);
            this.groupBoxManipulation.Controls.Add(this.panel1);
            this.groupBoxManipulation.Controls.Add(this.buttonTransformReverse);
            this.groupBoxManipulation.Controls.Add(this.groupBoxResize);
            this.groupBoxManipulation.Controls.Add(this.buttonTransformOrigin);
            this.groupBoxManipulation.Location = new System.Drawing.Point(688, 28);
            this.groupBoxManipulation.Name = "groupBoxManipulation";
            this.groupBoxManipulation.Size = new System.Drawing.Size(734, 721);
            this.groupBoxManipulation.TabIndex = 6;
            this.groupBoxManipulation.TabStop = false;
            this.groupBoxManipulation.Text = "Image Manipulations";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Info;
            this.panel7.Controls.Add(this.groupBoxCompression);
            this.panel7.Location = new System.Drawing.Point(359, 257);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(350, 87);
            this.panel7.TabIndex = 6;
            // 
            // groupBoxCompression
            // 
            this.groupBoxCompression.Controls.Add(this.textBoxCompressionBits);
            this.groupBoxCompression.Controls.Add(this.labelCompressionBits);
            this.groupBoxCompression.Controls.Add(this.button1);
            this.groupBoxCompression.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCompression.Name = "groupBoxCompression";
            this.groupBoxCompression.Size = new System.Drawing.Size(344, 81);
            this.groupBoxCompression.TabIndex = 0;
            this.groupBoxCompression.TabStop = false;
            this.groupBoxCompression.Text = "Compression";
            // 
            // textBoxCompressionBits
            // 
            this.textBoxCompressionBits.Location = new System.Drawing.Point(35, 21);
            this.textBoxCompressionBits.Name = "textBoxCompressionBits";
            this.textBoxCompressionBits.Size = new System.Drawing.Size(303, 22);
            this.textBoxCompressionBits.TabIndex = 7;
            // 
            // labelCompressionBits
            // 
            this.labelCompressionBits.AutoSize = true;
            this.labelCompressionBits.Location = new System.Drawing.Point(6, 24);
            this.labelCompressionBits.Name = "labelCompressionBits";
            this.labelCompressionBits.Size = new System.Drawing.Size(23, 12);
            this.labelCompressionBits.TabIndex = 2;
            this.labelCompressionBits.Text = "Bits";
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(213, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "8-bit plane slicing";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel6.Controls.Add(this.groupBoxSegmentation);
            this.panel6.Location = new System.Drawing.Point(359, 107);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(350, 144);
            this.panel6.TabIndex = 5;
            // 
            // groupBoxSegmentation
            // 
            this.groupBoxSegmentation.Controls.Add(this.textBoxIterationLevel);
            this.groupBoxSegmentation.Controls.Add(this.textBoxSegmentationK);
            this.groupBoxSegmentation.Controls.Add(this.labelSegmentationIterationLevel);
            this.groupBoxSegmentation.Controls.Add(this.labelSegmentationK);
            this.groupBoxSegmentation.Controls.Add(this.buttonSegmentationKmeans);
            this.groupBoxSegmentation.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSegmentation.Name = "groupBoxSegmentation";
            this.groupBoxSegmentation.Size = new System.Drawing.Size(344, 137);
            this.groupBoxSegmentation.TabIndex = 0;
            this.groupBoxSegmentation.TabStop = false;
            this.groupBoxSegmentation.Text = "Segmentation";
            // 
            // textBoxIterationLevel
            // 
            this.textBoxIterationLevel.Location = new System.Drawing.Point(85, 49);
            this.textBoxIterationLevel.Name = "textBoxIterationLevel";
            this.textBoxIterationLevel.Size = new System.Drawing.Size(253, 22);
            this.textBoxIterationLevel.TabIndex = 6;
            // 
            // textBoxSegmentationK
            // 
            this.textBoxSegmentationK.Location = new System.Drawing.Point(85, 21);
            this.textBoxSegmentationK.Name = "textBoxSegmentationK";
            this.textBoxSegmentationK.Size = new System.Drawing.Size(253, 22);
            this.textBoxSegmentationK.TabIndex = 5;
            // 
            // labelSegmentationIterationLevel
            // 
            this.labelSegmentationIterationLevel.AutoSize = true;
            this.labelSegmentationIterationLevel.Location = new System.Drawing.Point(6, 52);
            this.labelSegmentationIterationLevel.Name = "labelSegmentationIterationLevel";
            this.labelSegmentationIterationLevel.Size = new System.Drawing.Size(73, 12);
            this.labelSegmentationIterationLevel.TabIndex = 4;
            this.labelSegmentationIterationLevel.Text = "Iteration Level";
            // 
            // labelSegmentationK
            // 
            this.labelSegmentationK.AutoSize = true;
            this.labelSegmentationK.Location = new System.Drawing.Point(6, 24);
            this.labelSegmentationK.Name = "labelSegmentationK";
            this.labelSegmentationK.Size = new System.Drawing.Size(43, 12);
            this.labelSegmentationK.TabIndex = 3;
            this.labelSegmentationK.Text = "K Value";
            // 
            // buttonSegmentationKmeans
            // 
            this.buttonSegmentationKmeans.Enabled = false;
            this.buttonSegmentationKmeans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSegmentationKmeans.Location = new System.Drawing.Point(263, 77);
            this.buttonSegmentationKmeans.Name = "buttonSegmentationKmeans";
            this.buttonSegmentationKmeans.Size = new System.Drawing.Size(75, 23);
            this.buttonSegmentationKmeans.TabIndex = 2;
            this.buttonSegmentationKmeans.Text = "K Means";
            this.buttonSegmentationKmeans.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.groupBoxEncryption);
            this.panel5.Location = new System.Drawing.Point(6, 542);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(350, 117);
            this.panel5.TabIndex = 6;
            // 
            // groupBoxEncryption
            // 
            this.groupBoxEncryption.Controls.Add(this.textBoxEncryptionKey);
            this.groupBoxEncryption.Controls.Add(this.ButtonEncryptionClear);
            this.groupBoxEncryption.Controls.Add(this.ButtonEncryptionDecrypt);
            this.groupBoxEncryption.Controls.Add(this.buttonEncryptionEncrypt);
            this.groupBoxEncryption.Location = new System.Drawing.Point(3, 3);
            this.groupBoxEncryption.Name = "groupBoxEncryption";
            this.groupBoxEncryption.Size = new System.Drawing.Size(344, 110);
            this.groupBoxEncryption.TabIndex = 0;
            this.groupBoxEncryption.TabStop = false;
            this.groupBoxEncryption.Text = "Encryption";
            // 
            // textBoxEncryptionKey
            // 
            this.textBoxEncryptionKey.Location = new System.Drawing.Point(6, 21);
            this.textBoxEncryptionKey.Multiline = true;
            this.textBoxEncryptionKey.Name = "textBoxEncryptionKey";
            this.textBoxEncryptionKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEncryptionKey.Size = new System.Drawing.Size(251, 81);
            this.textBoxEncryptionKey.TabIndex = 3;
            // 
            // ButtonEncryptionClear
            // 
            this.ButtonEncryptionClear.Enabled = false;
            this.ButtonEncryptionClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEncryptionClear.Location = new System.Drawing.Point(263, 79);
            this.ButtonEncryptionClear.Name = "ButtonEncryptionClear";
            this.ButtonEncryptionClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonEncryptionClear.TabIndex = 2;
            this.ButtonEncryptionClear.Text = "Clear";
            this.ButtonEncryptionClear.UseVisualStyleBackColor = true;
            // 
            // ButtonEncryptionDecrypt
            // 
            this.ButtonEncryptionDecrypt.Enabled = false;
            this.ButtonEncryptionDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonEncryptionDecrypt.Location = new System.Drawing.Point(263, 50);
            this.ButtonEncryptionDecrypt.Name = "ButtonEncryptionDecrypt";
            this.ButtonEncryptionDecrypt.Size = new System.Drawing.Size(75, 23);
            this.ButtonEncryptionDecrypt.TabIndex = 1;
            this.ButtonEncryptionDecrypt.Text = "Decrypt";
            this.ButtonEncryptionDecrypt.UseVisualStyleBackColor = true;
            // 
            // buttonEncryptionEncrypt
            // 
            this.buttonEncryptionEncrypt.Enabled = false;
            this.buttonEncryptionEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEncryptionEncrypt.Location = new System.Drawing.Point(263, 21);
            this.buttonEncryptionEncrypt.Name = "buttonEncryptionEncrypt";
            this.buttonEncryptionEncrypt.Size = new System.Drawing.Size(75, 23);
            this.buttonEncryptionEncrypt.TabIndex = 0;
            this.buttonEncryptionEncrypt.Text = "Encrypt";
            this.buttonEncryptionEncrypt.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel4.Controls.Add(this.groupBoxMorphology);
            this.panel4.Location = new System.Drawing.Point(6, 477);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 59);
            this.panel4.TabIndex = 5;
            // 
            // groupBoxMorphology
            // 
            this.groupBoxMorphology.Controls.Add(this.buttonMorphlogyClosing);
            this.groupBoxMorphology.Controls.Add(this.buttonMorphologyOpening);
            this.groupBoxMorphology.Controls.Add(this.buttonMorphologyDilation);
            this.groupBoxMorphology.Controls.Add(this.buttonMorphologyErosion);
            this.groupBoxMorphology.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMorphology.Name = "groupBoxMorphology";
            this.groupBoxMorphology.Size = new System.Drawing.Size(344, 52);
            this.groupBoxMorphology.TabIndex = 0;
            this.groupBoxMorphology.TabStop = false;
            this.groupBoxMorphology.Text = "Morphology";
            // 
            // buttonMorphlogyClosing
            // 
            this.buttonMorphlogyClosing.Enabled = false;
            this.buttonMorphlogyClosing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMorphlogyClosing.Location = new System.Drawing.Point(249, 21);
            this.buttonMorphlogyClosing.Name = "buttonMorphlogyClosing";
            this.buttonMorphlogyClosing.Size = new System.Drawing.Size(75, 23);
            this.buttonMorphlogyClosing.TabIndex = 4;
            this.buttonMorphlogyClosing.Text = "Closing";
            this.buttonMorphlogyClosing.UseVisualStyleBackColor = true;
            // 
            // buttonMorphologyOpening
            // 
            this.buttonMorphologyOpening.Enabled = false;
            this.buttonMorphologyOpening.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMorphologyOpening.Location = new System.Drawing.Point(168, 21);
            this.buttonMorphologyOpening.Name = "buttonMorphologyOpening";
            this.buttonMorphologyOpening.Size = new System.Drawing.Size(75, 23);
            this.buttonMorphologyOpening.TabIndex = 3;
            this.buttonMorphologyOpening.Text = "Opening";
            this.buttonMorphologyOpening.UseVisualStyleBackColor = true;
            // 
            // buttonMorphologyDilation
            // 
            this.buttonMorphologyDilation.Enabled = false;
            this.buttonMorphologyDilation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMorphologyDilation.Location = new System.Drawing.Point(87, 21);
            this.buttonMorphologyDilation.Name = "buttonMorphologyDilation";
            this.buttonMorphologyDilation.Size = new System.Drawing.Size(75, 23);
            this.buttonMorphologyDilation.TabIndex = 2;
            this.buttonMorphologyDilation.Text = "Dilation";
            this.buttonMorphologyDilation.UseVisualStyleBackColor = true;
            // 
            // buttonMorphologyErosion
            // 
            this.buttonMorphologyErosion.Enabled = false;
            this.buttonMorphologyErosion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMorphologyErosion.Location = new System.Drawing.Point(6, 21);
            this.buttonMorphologyErosion.Name = "buttonMorphologyErosion";
            this.buttonMorphologyErosion.Size = new System.Drawing.Size(75, 23);
            this.buttonMorphologyErosion.TabIndex = 1;
            this.buttonMorphologyErosion.Text = "Erosion";
            this.buttonMorphologyErosion.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Info;
            this.panel3.Controls.Add(this.groupBoxSpaceFilter);
            this.panel3.Location = new System.Drawing.Point(6, 382);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 87);
            this.panel3.TabIndex = 5;
            // 
            // groupBoxSpaceFilter
            // 
            this.groupBoxSpaceFilter.Controls.Add(this.buttonSpaceFilterMax);
            this.groupBoxSpaceFilter.Controls.Add(this.buttonSpaceFilterMin);
            this.groupBoxSpaceFilter.Controls.Add(this.buttonSpaceFilterKirsch);
            this.groupBoxSpaceFilter.Controls.Add(this.buttonSpaceFilterLaplacian);
            this.groupBoxSpaceFilter.Controls.Add(this.buttonSpaceFilterSobel);
            this.groupBoxSpaceFilter.Controls.Add(this.buttonSpaceFilterMean);
            this.groupBoxSpaceFilter.Controls.Add(this.buttonSpaceFilterMedium);
            this.groupBoxSpaceFilter.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSpaceFilter.Name = "groupBoxSpaceFilter";
            this.groupBoxSpaceFilter.Size = new System.Drawing.Size(344, 81);
            this.groupBoxSpaceFilter.TabIndex = 0;
            this.groupBoxSpaceFilter.TabStop = false;
            this.groupBoxSpaceFilter.Text = "Space Filter";
            // 
            // buttonSpaceFilterKirsch
            // 
            this.buttonSpaceFilterKirsch.Enabled = false;
            this.buttonSpaceFilterKirsch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpaceFilterKirsch.Location = new System.Drawing.Point(168, 50);
            this.buttonSpaceFilterKirsch.Name = "buttonSpaceFilterKirsch";
            this.buttonSpaceFilterKirsch.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFilterKirsch.TabIndex = 4;
            this.buttonSpaceFilterKirsch.Text = "Kirsch";
            this.buttonSpaceFilterKirsch.UseVisualStyleBackColor = true;
            // 
            // buttonSpaceFilterLaplacian
            // 
            this.buttonSpaceFilterLaplacian.Enabled = false;
            this.buttonSpaceFilterLaplacian.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpaceFilterLaplacian.Location = new System.Drawing.Point(87, 50);
            this.buttonSpaceFilterLaplacian.Name = "buttonSpaceFilterLaplacian";
            this.buttonSpaceFilterLaplacian.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFilterLaplacian.TabIndex = 3;
            this.buttonSpaceFilterLaplacian.Text = "Laplacian";
            this.buttonSpaceFilterLaplacian.UseVisualStyleBackColor = true;
            // 
            // buttonSpaceFilterSobel
            // 
            this.buttonSpaceFilterSobel.Enabled = false;
            this.buttonSpaceFilterSobel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSpaceFilterSobel.Location = new System.Drawing.Point(6, 50);
            this.buttonSpaceFilterSobel.Name = "buttonSpaceFilterSobel";
            this.buttonSpaceFilterSobel.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFilterSobel.TabIndex = 2;
            this.buttonSpaceFilterSobel.Text = "Sobel";
            this.buttonSpaceFilterSobel.UseVisualStyleBackColor = true;
            // 
            // buttonSpaceFilterMean
            // 
            this.buttonSpaceFilterMean.Location = new System.Drawing.Point(87, 21);
            this.buttonSpaceFilterMean.Name = "buttonSpaceFilterMean";
            this.buttonSpaceFilterMean.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFilterMean.TabIndex = 1;
            this.buttonSpaceFilterMean.Text = "Mean";
            this.buttonSpaceFilterMean.UseVisualStyleBackColor = true;
            this.buttonSpaceFilterMean.Click += new System.EventHandler(this.buttonSpaceFillerMean_Click);
            // 
            // buttonSpaceFilterMedium
            // 
            this.buttonSpaceFilterMedium.Location = new System.Drawing.Point(6, 21);
            this.buttonSpaceFilterMedium.Name = "buttonSpaceFilterMedium";
            this.buttonSpaceFilterMedium.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFilterMedium.TabIndex = 0;
            this.buttonSpaceFilterMedium.Text = "Median";
            this.buttonSpaceFilterMedium.UseVisualStyleBackColor = true;
            this.buttonSpaceFilterMedium.Click += new System.EventHandler(this.buttonSpaceFillerMedium_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.groupBoxContrast);
            this.panel2.Location = new System.Drawing.Point(6, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 87);
            this.panel2.TabIndex = 4;
            // 
            // groupBoxContrast
            // 
            this.groupBoxContrast.Controls.Add(this.buttonPowerLaw);
            this.groupBoxContrast.Controls.Add(this.buttonContrastLogarithmic);
            this.groupBoxContrast.Controls.Add(this.buttonContrastNegative);
            this.groupBoxContrast.Controls.Add(this.buttonContrastSharpening);
            this.groupBoxContrast.Controls.Add(this.buttonContrastHistogramEqualization);
            this.groupBoxContrast.Location = new System.Drawing.Point(3, 3);
            this.groupBoxContrast.Name = "groupBoxContrast";
            this.groupBoxContrast.Size = new System.Drawing.Size(344, 81);
            this.groupBoxContrast.TabIndex = 0;
            this.groupBoxContrast.TabStop = false;
            this.groupBoxContrast.Text = "Contrast";
            // 
            // buttonPowerLaw
            // 
            this.buttonPowerLaw.Location = new System.Drawing.Point(249, 50);
            this.buttonPowerLaw.Name = "buttonPowerLaw";
            this.buttonPowerLaw.Size = new System.Drawing.Size(75, 23);
            this.buttonPowerLaw.TabIndex = 4;
            this.buttonPowerLaw.Text = "Power-Law";
            this.buttonPowerLaw.UseVisualStyleBackColor = true;
            this.buttonPowerLaw.Click += new System.EventHandler(this.buttonPowerLaw_Click);
            // 
            // buttonContrastLogarithmic
            // 
            this.buttonContrastLogarithmic.Location = new System.Drawing.Point(168, 50);
            this.buttonContrastLogarithmic.Name = "buttonContrastLogarithmic";
            this.buttonContrastLogarithmic.Size = new System.Drawing.Size(75, 23);
            this.buttonContrastLogarithmic.TabIndex = 3;
            this.buttonContrastLogarithmic.Text = "Logarithmic";
            this.buttonContrastLogarithmic.UseVisualStyleBackColor = true;
            this.buttonContrastLogarithmic.Click += new System.EventHandler(this.buttonContrastLogarithmic_Click);
            // 
            // buttonContrastNegative
            // 
            this.buttonContrastNegative.Location = new System.Drawing.Point(87, 50);
            this.buttonContrastNegative.Name = "buttonContrastNegative";
            this.buttonContrastNegative.Size = new System.Drawing.Size(75, 23);
            this.buttonContrastNegative.TabIndex = 2;
            this.buttonContrastNegative.Text = "Negative";
            this.buttonContrastNegative.UseVisualStyleBackColor = true;
            this.buttonContrastNegative.Click += new System.EventHandler(this.buttonContrastNegative_Click);
            // 
            // buttonContrastSharpening
            // 
            this.buttonContrastSharpening.Enabled = false;
            this.buttonContrastSharpening.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContrastSharpening.Location = new System.Drawing.Point(6, 50);
            this.buttonContrastSharpening.Name = "buttonContrastSharpening";
            this.buttonContrastSharpening.Size = new System.Drawing.Size(75, 23);
            this.buttonContrastSharpening.TabIndex = 1;
            this.buttonContrastSharpening.Text = "Sharpening";
            this.buttonContrastSharpening.UseVisualStyleBackColor = true;
            // 
            // buttonContrastHistogramEqualization
            // 
            this.buttonContrastHistogramEqualization.Location = new System.Drawing.Point(6, 21);
            this.buttonContrastHistogramEqualization.Name = "buttonContrastHistogramEqualization";
            this.buttonContrastHistogramEqualization.Size = new System.Drawing.Size(150, 23);
            this.buttonContrastHistogramEqualization.TabIndex = 0;
            this.buttonContrastHistogramEqualization.Text = "Histogram Equalization";
            this.buttonContrastHistogramEqualization.UseVisualStyleBackColor = true;
            this.buttonContrastHistogramEqualization.Click += new System.EventHandler(this.buttonContrastHistogramEqualization_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.groupBoxBrightness);
            this.panel1.Controls.Add(this.groupBoxThresholding);
            this.panel1.Controls.Add(this.groupBoxGrayscale);
            this.panel1.Location = new System.Drawing.Point(6, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 176);
            this.panel1.TabIndex = 3;
            // 
            // groupBoxBrightness
            // 
            this.groupBoxBrightness.Controls.Add(this.buttonBrightnessDarken);
            this.groupBoxBrightness.Controls.Add(this.buttonBrightnessBrighten);
            this.groupBoxBrightness.Location = new System.Drawing.Point(3, 117);
            this.groupBoxBrightness.Name = "groupBoxBrightness";
            this.groupBoxBrightness.Size = new System.Drawing.Size(344, 52);
            this.groupBoxBrightness.TabIndex = 3;
            this.groupBoxBrightness.TabStop = false;
            this.groupBoxBrightness.Text = "Brightness";
            // 
            // buttonBrightnessDarken
            // 
            this.buttonBrightnessDarken.Enabled = false;
            this.buttonBrightnessDarken.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBrightnessDarken.Location = new System.Drawing.Point(112, 21);
            this.buttonBrightnessDarken.Name = "buttonBrightnessDarken";
            this.buttonBrightnessDarken.Size = new System.Drawing.Size(100, 23);
            this.buttonBrightnessDarken.TabIndex = 1;
            this.buttonBrightnessDarken.Text = "Darken";
            this.buttonBrightnessDarken.UseVisualStyleBackColor = true;
            // 
            // buttonBrightnessBrighten
            // 
            this.buttonBrightnessBrighten.Enabled = false;
            this.buttonBrightnessBrighten.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBrightnessBrighten.Location = new System.Drawing.Point(6, 21);
            this.buttonBrightnessBrighten.Name = "buttonBrightnessBrighten";
            this.buttonBrightnessBrighten.Size = new System.Drawing.Size(100, 23);
            this.buttonBrightnessBrighten.TabIndex = 0;
            this.buttonBrightnessBrighten.Text = "Brighten";
            this.buttonBrightnessBrighten.UseVisualStyleBackColor = true;
            // 
            // groupBoxThresholding
            // 
            this.groupBoxThresholding.Controls.Add(this.buttonThresholdingOtsuMethod);
            this.groupBoxThresholding.Location = new System.Drawing.Point(3, 61);
            this.groupBoxThresholding.Name = "groupBoxThresholding";
            this.groupBoxThresholding.Size = new System.Drawing.Size(344, 52);
            this.groupBoxThresholding.TabIndex = 3;
            this.groupBoxThresholding.TabStop = false;
            this.groupBoxThresholding.Text = "Thresholding";
            // 
            // buttonThresholdingOtsuMethod
            // 
            this.buttonThresholdingOtsuMethod.Enabled = false;
            this.buttonThresholdingOtsuMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonThresholdingOtsuMethod.Location = new System.Drawing.Point(6, 21);
            this.buttonThresholdingOtsuMethod.Name = "buttonThresholdingOtsuMethod";
            this.buttonThresholdingOtsuMethod.Size = new System.Drawing.Size(100, 23);
            this.buttonThresholdingOtsuMethod.TabIndex = 0;
            this.buttonThresholdingOtsuMethod.Text = "Otsu\'s method";
            this.buttonThresholdingOtsuMethod.UseVisualStyleBackColor = true;
            // 
            // groupBoxGrayscale
            // 
            this.groupBoxGrayscale.Controls.Add(this.buttonMaximum);
            this.groupBoxGrayscale.Controls.Add(this.buttonGrayscaleMeanValue);
            this.groupBoxGrayscale.Controls.Add(this.buttonGrayscaleMeanWeight);
            this.groupBoxGrayscale.Location = new System.Drawing.Point(3, 3);
            this.groupBoxGrayscale.Name = "groupBoxGrayscale";
            this.groupBoxGrayscale.Size = new System.Drawing.Size(344, 52);
            this.groupBoxGrayscale.TabIndex = 2;
            this.groupBoxGrayscale.TabStop = false;
            this.groupBoxGrayscale.Text = "Grayscale";
            // 
            // buttonMaximum
            // 
            this.buttonMaximum.Location = new System.Drawing.Point(218, 21);
            this.buttonMaximum.Name = "buttonMaximum";
            this.buttonMaximum.Size = new System.Drawing.Size(100, 23);
            this.buttonMaximum.TabIndex = 2;
            this.buttonMaximum.Text = "Maximum";
            this.buttonMaximum.UseVisualStyleBackColor = true;
            this.buttonMaximum.Click += new System.EventHandler(this.buttonMaximum_Click);
            // 
            // buttonGrayscaleMeanValue
            // 
            this.buttonGrayscaleMeanValue.Location = new System.Drawing.Point(112, 21);
            this.buttonGrayscaleMeanValue.Name = "buttonGrayscaleMeanValue";
            this.buttonGrayscaleMeanValue.Size = new System.Drawing.Size(100, 23);
            this.buttonGrayscaleMeanValue.TabIndex = 1;
            this.buttonGrayscaleMeanValue.Text = "Mean Value";
            this.buttonGrayscaleMeanValue.UseVisualStyleBackColor = true;
            this.buttonGrayscaleMeanValue.Click += new System.EventHandler(this.buttonGrayscaleMeanValue_Click);
            // 
            // buttonGrayscaleMeanWeight
            // 
            this.buttonGrayscaleMeanWeight.Location = new System.Drawing.Point(6, 21);
            this.buttonGrayscaleMeanWeight.Name = "buttonGrayscaleMeanWeight";
            this.buttonGrayscaleMeanWeight.Size = new System.Drawing.Size(100, 23);
            this.buttonGrayscaleMeanWeight.TabIndex = 0;
            this.buttonGrayscaleMeanWeight.Text = "Mean Weight";
            this.buttonGrayscaleMeanWeight.UseVisualStyleBackColor = true;
            this.buttonGrayscaleMeanWeight.Click += new System.EventHandler(this.buttonGrayscaleMeanWeight_Click);
            // 
            // buttonTransformReverse
            // 
            this.buttonTransformReverse.Enabled = false;
            this.buttonTransformReverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTransformReverse.Location = new System.Drawing.Point(6, 69);
            this.buttonTransformReverse.Name = "buttonTransformReverse";
            this.buttonTransformReverse.Size = new System.Drawing.Size(75, 23);
            this.buttonTransformReverse.TabIndex = 1;
            this.buttonTransformReverse.Text = "Reverse";
            this.buttonTransformReverse.UseVisualStyleBackColor = true;
            // 
            // groupBoxResize
            // 
            this.groupBoxResize.Controls.Add(this.buttonDoResize);
            this.groupBoxResize.Controls.Add(this.textBoxResizeHeight);
            this.groupBoxResize.Controls.Add(this.labelResizeHeight);
            this.groupBoxResize.Controls.Add(this.textBoxResizeX);
            this.groupBoxResize.Controls.Add(this.labelResizeWidth);
            this.groupBoxResize.Location = new System.Drawing.Point(87, 21);
            this.groupBoxResize.Name = "groupBoxResize";
            this.groupBoxResize.Size = new System.Drawing.Size(191, 80);
            this.groupBoxResize.TabIndex = 0;
            this.groupBoxResize.TabStop = false;
            this.groupBoxResize.Text = "Resize";
            // 
            // buttonDoResize
            // 
            this.buttonDoResize.Enabled = false;
            this.buttonDoResize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDoResize.Location = new System.Drawing.Point(104, 20);
            this.buttonDoResize.Name = "buttonDoResize";
            this.buttonDoResize.Size = new System.Drawing.Size(75, 51);
            this.buttonDoResize.TabIndex = 4;
            this.buttonDoResize.Text = "Resize";
            this.buttonDoResize.UseVisualStyleBackColor = true;
            // 
            // textBoxResizeHeight
            // 
            this.textBoxResizeHeight.Location = new System.Drawing.Point(48, 49);
            this.textBoxResizeHeight.Name = "textBoxResizeHeight";
            this.textBoxResizeHeight.Size = new System.Drawing.Size(50, 22);
            this.textBoxResizeHeight.TabIndex = 3;
            // 
            // labelResizeHeight
            // 
            this.labelResizeHeight.AutoSize = true;
            this.labelResizeHeight.Location = new System.Drawing.Point(6, 52);
            this.labelResizeHeight.Name = "labelResizeHeight";
            this.labelResizeHeight.Size = new System.Drawing.Size(36, 12);
            this.labelResizeHeight.TabIndex = 2;
            this.labelResizeHeight.Text = "Height";
            // 
            // textBoxResizeX
            // 
            this.textBoxResizeX.Location = new System.Drawing.Point(48, 21);
            this.textBoxResizeX.Name = "textBoxResizeX";
            this.textBoxResizeX.Size = new System.Drawing.Size(50, 22);
            this.textBoxResizeX.TabIndex = 1;
            // 
            // labelResizeWidth
            // 
            this.labelResizeWidth.AutoSize = true;
            this.labelResizeWidth.Location = new System.Drawing.Point(6, 24);
            this.labelResizeWidth.Name = "labelResizeWidth";
            this.labelResizeWidth.Size = new System.Drawing.Size(34, 12);
            this.labelResizeWidth.TabIndex = 0;
            this.labelResizeWidth.Text = "Width";
            // 
            // buttonTransformOrigin
            // 
            this.buttonTransformOrigin.Enabled = false;
            this.buttonTransformOrigin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTransformOrigin.Location = new System.Drawing.Point(6, 41);
            this.buttonTransformOrigin.Name = "buttonTransformOrigin";
            this.buttonTransformOrigin.Size = new System.Drawing.Size(75, 23);
            this.buttonTransformOrigin.TabIndex = 0;
            this.buttonTransformOrigin.Text = "Origin";
            this.buttonTransformOrigin.UseVisualStyleBackColor = true;
            // 
            // timerEnableControl
            // 
            this.timerEnableControl.Enabled = true;
            this.timerEnableControl.Tick += new System.EventHandler(this.timerEnableControl_Tick);
            // 
            // buttonSpaceFilterMin
            // 
            this.buttonSpaceFilterMin.Location = new System.Drawing.Point(168, 21);
            this.buttonSpaceFilterMin.Name = "buttonSpaceFilterMin";
            this.buttonSpaceFilterMin.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFilterMin.TabIndex = 5;
            this.buttonSpaceFilterMin.Text = "Min";
            this.buttonSpaceFilterMin.UseVisualStyleBackColor = true;
            this.buttonSpaceFilterMin.Click += new System.EventHandler(this.buttonSpaceFilterMin_Click);
            // 
            // buttonSpaceFilterMax
            // 
            this.buttonSpaceFilterMax.Location = new System.Drawing.Point(249, 21);
            this.buttonSpaceFilterMax.Name = "buttonSpaceFilterMax";
            this.buttonSpaceFilterMax.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFilterMax.TabIndex = 6;
            this.buttonSpaceFilterMax.Text = "Max";
            this.buttonSpaceFilterMax.UseVisualStyleBackColor = true;
            this.buttonSpaceFilterMax.Click += new System.EventHandler(this.buttonSpaceFilterMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 761);
            this.Controls.Add(this.groupBoxManipulation);
            this.Controls.Add(this.groupBoxLog);
            this.Controls.Add(this.groupBoxOut);
            this.Controls.Add(this.groupBoxIn);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Image Processing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxIn.ResumeLayout(false);
            this.groupBoxIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInBonly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInGonly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInRonly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInBGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInGGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInRGraph)).EndInit();
            this.groupBoxOut.ResumeLayout(false);
            this.groupBoxOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutBonly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutGonly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutRonly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutBGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutGGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutRGraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).EndInit();
            this.groupBoxLog.ResumeLayout(false);
            this.groupBoxManipulation.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBoxCompression.ResumeLayout(false);
            this.groupBoxCompression.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.groupBoxSegmentation.ResumeLayout(false);
            this.groupBoxSegmentation.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBoxEncryption.ResumeLayout(false);
            this.groupBoxEncryption.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBoxMorphology.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBoxSpaceFilter.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBoxContrast.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxBrightness.ResumeLayout(false);
            this.groupBoxThresholding.ResumeLayout(false);
            this.groupBoxGrayscale.ResumeLayout(false);
            this.groupBoxResize.ResumeLayout(false);
            this.groupBoxResize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.PictureBox pictureBoxInBGraph;
        private System.Windows.Forms.PictureBox pictureBoxInGGraph;
        private System.Windows.Forms.PictureBox pictureBoxInRGraph;
        private System.Windows.Forms.GroupBox groupBoxOut;
        private System.Windows.Forms.PictureBox pictureBoxOutBGraph;
        private System.Windows.Forms.PictureBox pictureBoxOutGGraph;
        private System.Windows.Forms.PictureBox pictureBoxOutRGraph;
        private System.Windows.Forms.PictureBox pictureBoxOut;
        private System.Windows.Forms.GroupBox groupBoxLog;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.GroupBox groupBoxManipulation;
        private System.Windows.Forms.Button buttonTransformReverse;
        private System.Windows.Forms.GroupBox groupBoxResize;
        private System.Windows.Forms.TextBox textBoxResizeHeight;
        private System.Windows.Forms.Label labelResizeHeight;
        private System.Windows.Forms.TextBox textBoxResizeX;
        private System.Windows.Forms.Label labelResizeWidth;
        private System.Windows.Forms.Button buttonTransformOrigin;
        private System.Windows.Forms.Button buttonDoResize;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxThresholding;
        private System.Windows.Forms.Button buttonThresholdingOtsuMethod;
        private System.Windows.Forms.GroupBox groupBoxGrayscale;
        private System.Windows.Forms.Button buttonMaximum;
        private System.Windows.Forms.Button buttonGrayscaleMeanValue;
        private System.Windows.Forms.Button buttonGrayscaleMeanWeight;
        private System.Windows.Forms.GroupBox groupBoxBrightness;
        private System.Windows.Forms.Button buttonBrightnessDarken;
        private System.Windows.Forms.Button buttonBrightnessBrighten;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBoxContrast;
        private System.Windows.Forms.Button buttonContrastHistogramEqualization;
        private System.Windows.Forms.Button buttonContrastSharpening;
        private System.Windows.Forms.Button buttonContrastLogarithmic;
        private System.Windows.Forms.Button buttonContrastNegative;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBoxSpaceFilter;
        private System.Windows.Forms.Button buttonSpaceFilterKirsch;
        private System.Windows.Forms.Button buttonSpaceFilterLaplacian;
        private System.Windows.Forms.Button buttonSpaceFilterSobel;
        private System.Windows.Forms.Button buttonSpaceFilterMean;
        private System.Windows.Forms.Button buttonSpaceFilterMedium;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBoxMorphology;
        private System.Windows.Forms.Button buttonMorphologyOpening;
        private System.Windows.Forms.Button buttonMorphologyDilation;
        private System.Windows.Forms.Button buttonMorphologyErosion;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.GroupBox groupBoxEncryption;
        private System.Windows.Forms.TextBox textBoxEncryptionKey;
        private System.Windows.Forms.Button ButtonEncryptionClear;
        private System.Windows.Forms.Button ButtonEncryptionDecrypt;
        private System.Windows.Forms.Button buttonEncryptionEncrypt;
        private System.Windows.Forms.Button buttonMorphlogyClosing;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBoxCompression;
        private System.Windows.Forms.Label labelCompressionBits;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBoxSegmentation;
        private System.Windows.Forms.Label labelSegmentationIterationLevel;
        private System.Windows.Forms.Label labelSegmentationK;
        private System.Windows.Forms.Button buttonSegmentationKmeans;
        private System.Windows.Forms.TextBox textBoxCompressionBits;
        private System.Windows.Forms.TextBox textBoxIterationLevel;
        private System.Windows.Forms.TextBox textBoxSegmentationK;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Label labelInImgSize;
        private System.Windows.Forms.Label labelOutImgSize;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonEdit;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxInBonly;
        private System.Windows.Forms.PictureBox pictureBoxInGonly;
        private System.Windows.Forms.PictureBox pictureBoxInRonly;
        private System.Windows.Forms.PictureBox pictureBoxOutBonly;
        private System.Windows.Forms.PictureBox pictureBoxOutGonly;
        private System.Windows.Forms.PictureBox pictureBoxOutRonly;
        private System.Windows.Forms.Label labelInB;
        private System.Windows.Forms.Label labelInG;
        private System.Windows.Forms.Label labelInR;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelOutG;
        private System.Windows.Forms.Label labelOutR;
        private System.Windows.Forms.Timer timerEnableControl;
        private System.Windows.Forms.Button buttonPowerLaw;
        private System.Windows.Forms.Button buttonSpaceFilterMax;
        private System.Windows.Forms.Button buttonSpaceFilterMin;
    }
}

