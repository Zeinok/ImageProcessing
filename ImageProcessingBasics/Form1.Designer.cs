﻿namespace ImageProcessingBasics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxIn = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.groupBoxIn = new System.Windows.Forms.GroupBox();
            this.pictureBoxInB = new System.Windows.Forms.PictureBox();
            this.pictureBoxInG = new System.Windows.Forms.PictureBox();
            this.pictureBoxInR = new System.Windows.Forms.PictureBox();
            this.groupBoxOut = new System.Windows.Forms.GroupBox();
            this.pictureBoxOutB = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutG = new System.Windows.Forms.PictureBox();
            this.pictureBoxOutR = new System.Windows.Forms.PictureBox();
            this.pictureBoxOut = new System.Windows.Forms.PictureBox();
            this.groupBoxLog = new System.Windows.Forms.GroupBox();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.groupBoxManipulation = new System.Windows.Forms.GroupBox();
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
            this.groupBoxSpaceFiller = new System.Windows.Forms.GroupBox();
            this.buttonSpaceFillerKirsch = new System.Windows.Forms.Button();
            this.buttonSpaceFillerLaplacian = new System.Windows.Forms.Button();
            this.buttonSpaceFillerSobel = new System.Windows.Forms.Button();
            this.buttonSpaceFillerMean = new System.Windows.Forms.Button();
            this.buttonSpaceFillerMedium = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBoxContrast = new System.Windows.Forms.GroupBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInR)).BeginInit();
            this.groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).BeginInit();
            this.groupBoxLog.SuspendLayout();
            this.groupBoxManipulation.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBoxEncryption.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBoxMorphology.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBoxSpaceFiller.SuspendLayout();
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
            this.pictureBoxIn.TabIndex = 0;
            this.pictureBoxIn.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1434, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(43, 22);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.ToolTipText = "Open";
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(38, 22);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.ToolTipText = "Save";
            // 
            // groupBoxIn
            // 
            this.groupBoxIn.Controls.Add(this.pictureBoxInB);
            this.groupBoxIn.Controls.Add(this.pictureBoxInG);
            this.groupBoxIn.Controls.Add(this.pictureBoxInR);
            this.groupBoxIn.Controls.Add(this.pictureBoxIn);
            this.groupBoxIn.Location = new System.Drawing.Point(12, 28);
            this.groupBoxIn.Name = "groupBoxIn";
            this.groupBoxIn.Size = new System.Drawing.Size(332, 440);
            this.groupBoxIn.TabIndex = 3;
            this.groupBoxIn.TabStop = false;
            this.groupBoxIn.Text = "Original Image";
            // 
            // pictureBoxInB
            // 
            this.pictureBoxInB.Location = new System.Drawing.Point(178, 347);
            this.pictureBoxInB.Name = "pictureBoxInB";
            this.pictureBoxInB.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxInB.TabIndex = 3;
            this.pictureBoxInB.TabStop = false;
            // 
            // pictureBoxInG
            // 
            this.pictureBoxInG.Location = new System.Drawing.Point(92, 347);
            this.pictureBoxInG.Name = "pictureBoxInG";
            this.pictureBoxInG.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxInG.TabIndex = 2;
            this.pictureBoxInG.TabStop = false;
            // 
            // pictureBoxInR
            // 
            this.pictureBoxInR.Location = new System.Drawing.Point(6, 347);
            this.pictureBoxInR.Name = "pictureBoxInR";
            this.pictureBoxInR.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxInR.TabIndex = 1;
            this.pictureBoxInR.TabStop = false;
            // 
            // groupBoxOut
            // 
            this.groupBoxOut.Controls.Add(this.pictureBoxOutB);
            this.groupBoxOut.Controls.Add(this.pictureBoxOutG);
            this.groupBoxOut.Controls.Add(this.pictureBoxOutR);
            this.groupBoxOut.Controls.Add(this.pictureBoxOut);
            this.groupBoxOut.Location = new System.Drawing.Point(350, 28);
            this.groupBoxOut.Name = "groupBoxOut";
            this.groupBoxOut.Size = new System.Drawing.Size(332, 440);
            this.groupBoxOut.TabIndex = 4;
            this.groupBoxOut.TabStop = false;
            this.groupBoxOut.Text = "Result Image";
            // 
            // pictureBoxOutB
            // 
            this.pictureBoxOutB.Location = new System.Drawing.Point(178, 347);
            this.pictureBoxOutB.Name = "pictureBoxOutB";
            this.pictureBoxOutB.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxOutB.TabIndex = 3;
            this.pictureBoxOutB.TabStop = false;
            // 
            // pictureBoxOutG
            // 
            this.pictureBoxOutG.Location = new System.Drawing.Point(92, 347);
            this.pictureBoxOutG.Name = "pictureBoxOutG";
            this.pictureBoxOutG.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxOutG.TabIndex = 2;
            this.pictureBoxOutG.TabStop = false;
            // 
            // pictureBoxOutR
            // 
            this.pictureBoxOutR.Location = new System.Drawing.Point(6, 347);
            this.pictureBoxOutR.Name = "pictureBoxOutR";
            this.pictureBoxOutR.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxOutR.TabIndex = 1;
            this.pictureBoxOutR.TabStop = false;
            // 
            // pictureBoxOut
            // 
            this.pictureBoxOut.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxOut.Name = "pictureBoxOut";
            this.pictureBoxOut.Size = new System.Drawing.Size(320, 320);
            this.pictureBoxOut.TabIndex = 0;
            this.pictureBoxOut.TabStop = false;
            // 
            // groupBoxLog
            // 
            this.groupBoxLog.Controls.Add(this.listBoxLog);
            this.groupBoxLog.Location = new System.Drawing.Point(12, 474);
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
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Info;
            this.panel5.Controls.Add(this.groupBoxEncryption);
            this.panel5.Location = new System.Drawing.Point(6, 532);
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
            this.ButtonEncryptionClear.Location = new System.Drawing.Point(263, 79);
            this.ButtonEncryptionClear.Name = "ButtonEncryptionClear";
            this.ButtonEncryptionClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonEncryptionClear.TabIndex = 2;
            this.ButtonEncryptionClear.Text = "Clear";
            this.ButtonEncryptionClear.UseVisualStyleBackColor = true;
            // 
            // ButtonEncryptionDecrypt
            // 
            this.ButtonEncryptionDecrypt.Location = new System.Drawing.Point(263, 50);
            this.ButtonEncryptionDecrypt.Name = "ButtonEncryptionDecrypt";
            this.ButtonEncryptionDecrypt.Size = new System.Drawing.Size(75, 23);
            this.ButtonEncryptionDecrypt.TabIndex = 1;
            this.ButtonEncryptionDecrypt.Text = "Decrypt";
            this.ButtonEncryptionDecrypt.UseVisualStyleBackColor = true;
            // 
            // buttonEncryptionEncrypt
            // 
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
            this.panel4.Location = new System.Drawing.Point(6, 467);
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
            this.buttonMorphlogyClosing.Location = new System.Drawing.Point(249, 21);
            this.buttonMorphlogyClosing.Name = "buttonMorphlogyClosing";
            this.buttonMorphlogyClosing.Size = new System.Drawing.Size(75, 23);
            this.buttonMorphlogyClosing.TabIndex = 4;
            this.buttonMorphlogyClosing.Text = "Closing";
            this.buttonMorphlogyClosing.UseVisualStyleBackColor = true;
            // 
            // buttonMorphologyOpening
            // 
            this.buttonMorphologyOpening.Location = new System.Drawing.Point(168, 21);
            this.buttonMorphologyOpening.Name = "buttonMorphologyOpening";
            this.buttonMorphologyOpening.Size = new System.Drawing.Size(75, 23);
            this.buttonMorphologyOpening.TabIndex = 3;
            this.buttonMorphologyOpening.Text = "Opening";
            this.buttonMorphologyOpening.UseVisualStyleBackColor = true;
            // 
            // buttonMorphologyDilation
            // 
            this.buttonMorphologyDilation.Location = new System.Drawing.Point(87, 21);
            this.buttonMorphologyDilation.Name = "buttonMorphologyDilation";
            this.buttonMorphologyDilation.Size = new System.Drawing.Size(75, 23);
            this.buttonMorphologyDilation.TabIndex = 2;
            this.buttonMorphologyDilation.Text = "Dilation";
            this.buttonMorphologyDilation.UseVisualStyleBackColor = true;
            // 
            // buttonMorphologyErosion
            // 
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
            this.panel3.Controls.Add(this.groupBoxSpaceFiller);
            this.panel3.Location = new System.Drawing.Point(6, 372);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 87);
            this.panel3.TabIndex = 5;
            // 
            // groupBoxSpaceFiller
            // 
            this.groupBoxSpaceFiller.Controls.Add(this.buttonSpaceFillerKirsch);
            this.groupBoxSpaceFiller.Controls.Add(this.buttonSpaceFillerLaplacian);
            this.groupBoxSpaceFiller.Controls.Add(this.buttonSpaceFillerSobel);
            this.groupBoxSpaceFiller.Controls.Add(this.buttonSpaceFillerMean);
            this.groupBoxSpaceFiller.Controls.Add(this.buttonSpaceFillerMedium);
            this.groupBoxSpaceFiller.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSpaceFiller.Name = "groupBoxSpaceFiller";
            this.groupBoxSpaceFiller.Size = new System.Drawing.Size(344, 81);
            this.groupBoxSpaceFiller.TabIndex = 0;
            this.groupBoxSpaceFiller.TabStop = false;
            this.groupBoxSpaceFiller.Text = "Space Filler";
            // 
            // buttonSpaceFillerKirsch
            // 
            this.buttonSpaceFillerKirsch.Location = new System.Drawing.Point(168, 50);
            this.buttonSpaceFillerKirsch.Name = "buttonSpaceFillerKirsch";
            this.buttonSpaceFillerKirsch.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFillerKirsch.TabIndex = 4;
            this.buttonSpaceFillerKirsch.Text = "Kirsch";
            this.buttonSpaceFillerKirsch.UseVisualStyleBackColor = true;
            // 
            // buttonSpaceFillerLaplacian
            // 
            this.buttonSpaceFillerLaplacian.Location = new System.Drawing.Point(87, 50);
            this.buttonSpaceFillerLaplacian.Name = "buttonSpaceFillerLaplacian";
            this.buttonSpaceFillerLaplacian.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFillerLaplacian.TabIndex = 3;
            this.buttonSpaceFillerLaplacian.Text = "Laplacian";
            this.buttonSpaceFillerLaplacian.UseVisualStyleBackColor = true;
            // 
            // buttonSpaceFillerSobel
            // 
            this.buttonSpaceFillerSobel.Location = new System.Drawing.Point(6, 50);
            this.buttonSpaceFillerSobel.Name = "buttonSpaceFillerSobel";
            this.buttonSpaceFillerSobel.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFillerSobel.TabIndex = 2;
            this.buttonSpaceFillerSobel.Text = "Sobel";
            this.buttonSpaceFillerSobel.UseVisualStyleBackColor = true;
            // 
            // buttonSpaceFillerMean
            // 
            this.buttonSpaceFillerMean.Location = new System.Drawing.Point(87, 21);
            this.buttonSpaceFillerMean.Name = "buttonSpaceFillerMean";
            this.buttonSpaceFillerMean.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFillerMean.TabIndex = 1;
            this.buttonSpaceFillerMean.Text = "Mean";
            this.buttonSpaceFillerMean.UseVisualStyleBackColor = true;
            // 
            // buttonSpaceFillerMedium
            // 
            this.buttonSpaceFillerMedium.Location = new System.Drawing.Point(6, 21);
            this.buttonSpaceFillerMedium.Name = "buttonSpaceFillerMedium";
            this.buttonSpaceFillerMedium.Size = new System.Drawing.Size(75, 23);
            this.buttonSpaceFillerMedium.TabIndex = 0;
            this.buttonSpaceFillerMedium.Text = "Medium";
            this.buttonSpaceFillerMedium.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.groupBoxContrast);
            this.panel2.Location = new System.Drawing.Point(6, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 87);
            this.panel2.TabIndex = 4;
            // 
            // groupBoxContrast
            // 
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
            // buttonContrastLogarithmic
            // 
            this.buttonContrastLogarithmic.Location = new System.Drawing.Point(168, 50);
            this.buttonContrastLogarithmic.Name = "buttonContrastLogarithmic";
            this.buttonContrastLogarithmic.Size = new System.Drawing.Size(75, 23);
            this.buttonContrastLogarithmic.TabIndex = 3;
            this.buttonContrastLogarithmic.Text = "Logarithmic";
            this.buttonContrastLogarithmic.UseVisualStyleBackColor = true;
            // 
            // buttonContrastNegative
            // 
            this.buttonContrastNegative.Location = new System.Drawing.Point(87, 50);
            this.buttonContrastNegative.Name = "buttonContrastNegative";
            this.buttonContrastNegative.Size = new System.Drawing.Size(75, 23);
            this.buttonContrastNegative.TabIndex = 2;
            this.buttonContrastNegative.Text = "Negative";
            this.buttonContrastNegative.UseVisualStyleBackColor = true;
            // 
            // buttonContrastSharpening
            // 
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
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.groupBoxBrightness);
            this.panel1.Controls.Add(this.groupBoxThresholding);
            this.panel1.Controls.Add(this.groupBoxGrayscale);
            this.panel1.Location = new System.Drawing.Point(6, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 166);
            this.panel1.TabIndex = 3;
            // 
            // groupBoxBrightness
            // 
            this.groupBoxBrightness.Controls.Add(this.buttonBrightnessDarken);
            this.groupBoxBrightness.Controls.Add(this.buttonBrightnessBrighten);
            this.groupBoxBrightness.Location = new System.Drawing.Point(3, 111);
            this.groupBoxBrightness.Name = "groupBoxBrightness";
            this.groupBoxBrightness.Size = new System.Drawing.Size(344, 52);
            this.groupBoxBrightness.TabIndex = 3;
            this.groupBoxBrightness.TabStop = false;
            this.groupBoxBrightness.Text = "Brightness";
            // 
            // buttonBrightnessDarken
            // 
            this.buttonBrightnessDarken.Location = new System.Drawing.Point(112, 21);
            this.buttonBrightnessDarken.Name = "buttonBrightnessDarken";
            this.buttonBrightnessDarken.Size = new System.Drawing.Size(100, 23);
            this.buttonBrightnessDarken.TabIndex = 1;
            this.buttonBrightnessDarken.Text = "Darken";
            this.buttonBrightnessDarken.UseVisualStyleBackColor = true;
            // 
            // buttonBrightnessBrighten
            // 
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
            this.groupBoxThresholding.Location = new System.Drawing.Point(3, 53);
            this.groupBoxThresholding.Name = "groupBoxThresholding";
            this.groupBoxThresholding.Size = new System.Drawing.Size(344, 52);
            this.groupBoxThresholding.TabIndex = 3;
            this.groupBoxThresholding.TabStop = false;
            this.groupBoxThresholding.Text = "Thresholding";
            // 
            // buttonThresholdingOtsuMethod
            // 
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
            // 
            // buttonGrayscaleMeanValue
            // 
            this.buttonGrayscaleMeanValue.Location = new System.Drawing.Point(112, 21);
            this.buttonGrayscaleMeanValue.Name = "buttonGrayscaleMeanValue";
            this.buttonGrayscaleMeanValue.Size = new System.Drawing.Size(100, 23);
            this.buttonGrayscaleMeanValue.TabIndex = 1;
            this.buttonGrayscaleMeanValue.Text = "Mean Weight";
            this.buttonGrayscaleMeanValue.UseVisualStyleBackColor = true;
            // 
            // buttonGrayscaleMeanWeight
            // 
            this.buttonGrayscaleMeanWeight.Location = new System.Drawing.Point(6, 21);
            this.buttonGrayscaleMeanWeight.Name = "buttonGrayscaleMeanWeight";
            this.buttonGrayscaleMeanWeight.Size = new System.Drawing.Size(100, 23);
            this.buttonGrayscaleMeanWeight.TabIndex = 0;
            this.buttonGrayscaleMeanWeight.Text = "Mean Weight";
            this.buttonGrayscaleMeanWeight.UseVisualStyleBackColor = true;
            // 
            // buttonTransformReverse
            // 
            this.buttonTransformReverse.Location = new System.Drawing.Point(6, 50);
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
            this.buttonTransformOrigin.Location = new System.Drawing.Point(6, 21);
            this.buttonTransformOrigin.Name = "buttonTransformOrigin";
            this.buttonTransformOrigin.Size = new System.Drawing.Size(75, 23);
            this.buttonTransformOrigin.TabIndex = 0;
            this.buttonTransformOrigin.Text = "Origin";
            this.buttonTransformOrigin.UseVisualStyleBackColor = true;
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
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIn)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxInR)).EndInit();
            this.groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOutR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOut)).EndInit();
            this.groupBoxLog.ResumeLayout(false);
            this.groupBoxManipulation.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBoxEncryption.ResumeLayout(false);
            this.groupBoxEncryption.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.groupBoxMorphology.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBoxSpaceFiller.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.GroupBox groupBoxIn;
        private System.Windows.Forms.PictureBox pictureBoxInB;
        private System.Windows.Forms.PictureBox pictureBoxInG;
        private System.Windows.Forms.PictureBox pictureBoxInR;
        private System.Windows.Forms.GroupBox groupBoxOut;
        private System.Windows.Forms.PictureBox pictureBoxOutB;
        private System.Windows.Forms.PictureBox pictureBoxOutG;
        private System.Windows.Forms.PictureBox pictureBoxOutR;
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
        private System.Windows.Forms.GroupBox groupBoxSpaceFiller;
        private System.Windows.Forms.Button buttonSpaceFillerKirsch;
        private System.Windows.Forms.Button buttonSpaceFillerLaplacian;
        private System.Windows.Forms.Button buttonSpaceFillerSobel;
        private System.Windows.Forms.Button buttonSpaceFillerMean;
        private System.Windows.Forms.Button buttonSpaceFillerMedium;
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
    }
}

