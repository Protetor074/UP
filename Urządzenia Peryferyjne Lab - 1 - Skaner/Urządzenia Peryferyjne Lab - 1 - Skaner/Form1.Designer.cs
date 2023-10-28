namespace Urządzenia_Peryferyjne_Lab___1___Skaner
{
    partial class SkaningMode
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkaningMode));
            this.buttonScan = new System.Windows.Forms.Button();
            this.buttonRL_180 = new System.Windows.Forms.Button();
            this.labelRotationLeft = new System.Windows.Forms.Label();
            this.labelRotationRight = new System.Windows.Forms.Label();
            this.buttonRL_90 = new System.Windows.Forms.Button();
            this.buttonRL_270 = new System.Windows.Forms.Button();
            this.buttonRR_90 = new System.Windows.Forms.Button();
            this.buttonRR_180 = new System.Windows.Forms.Button();
            this.buttonRR_270 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelResolution = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.labelResolutionHeight = new System.Windows.Forms.Label();
            this.labelResolutionWidth = new System.Windows.Forms.Label();
            this.numericResolutionHeight = new System.Windows.Forms.NumericUpDown();
            this.numericResolutionWidth = new System.Windows.Forms.NumericUpDown();
            this.labelScaningType = new System.Windows.Forms.Label();
            this.domainScaningSelector = new System.Windows.Forms.DomainUpDown();
            this.labelSaveFileType = new System.Windows.Forms.Label();
            this.domainFormatSelector = new System.Windows.Forms.DomainUpDown();
            this.pictureBoxScan = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSkanerName = new System.Windows.Forms.Label();
            this.SkanerName = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.numericResolutionHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResolutionWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(10, 527);
            this.buttonScan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(74, 23);
            this.buttonScan.TabIndex = 0;
            this.buttonScan.Text = "Skanuj";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // buttonRL_180
            // 
            this.buttonRL_180.Location = new System.Drawing.Point(66, 334);
            this.buttonRL_180.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRL_180.Name = "buttonRL_180";
            this.buttonRL_180.Size = new System.Drawing.Size(38, 29);
            this.buttonRL_180.TabIndex = 5;
            this.buttonRL_180.Text = "180°";
            this.buttonRL_180.UseVisualStyleBackColor = true;
            this.buttonRL_180.Click += new System.EventHandler(this.buttonRL_180_Click);
            // 
            // labelRotationLeft
            // 
            this.labelRotationLeft.AutoSize = true;
            this.labelRotationLeft.Location = new System.Drawing.Point(50, 318);
            this.labelRotationLeft.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRotationLeft.Name = "labelRotationLeft";
            this.labelRotationLeft.Size = new System.Drawing.Size(69, 13);
            this.labelRotationLeft.TabIndex = 7;
            this.labelRotationLeft.Text = "Obrót w lewo";
            // 
            // labelRotationRight
            // 
            this.labelRotationRight.AutoSize = true;
            this.labelRotationRight.Location = new System.Drawing.Point(50, 262);
            this.labelRotationRight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRotationRight.Name = "labelRotationRight";
            this.labelRotationRight.Size = new System.Drawing.Size(76, 13);
            this.labelRotationRight.TabIndex = 8;
            this.labelRotationRight.Text = "Obrót w prawo";
            // 
            // buttonRL_90
            // 
            this.buttonRL_90.Location = new System.Drawing.Point(110, 334);
            this.buttonRL_90.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRL_90.Name = "buttonRL_90";
            this.buttonRL_90.Size = new System.Drawing.Size(38, 29);
            this.buttonRL_90.TabIndex = 9;
            this.buttonRL_90.Text = "90°";
            this.buttonRL_90.UseVisualStyleBackColor = true;
            this.buttonRL_90.Click += new System.EventHandler(this.buttonRL_90_Click);
            // 
            // buttonRL_270
            // 
            this.buttonRL_270.Location = new System.Drawing.Point(22, 334);
            this.buttonRL_270.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRL_270.Name = "buttonRL_270";
            this.buttonRL_270.Size = new System.Drawing.Size(38, 29);
            this.buttonRL_270.TabIndex = 10;
            this.buttonRL_270.Text = "270°";
            this.buttonRL_270.UseVisualStyleBackColor = true;
            this.buttonRL_270.Click += new System.EventHandler(this.buttonRL_270_Click);
            // 
            // buttonRR_90
            // 
            this.buttonRR_90.Location = new System.Drawing.Point(110, 278);
            this.buttonRR_90.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRR_90.Name = "buttonRR_90";
            this.buttonRR_90.Size = new System.Drawing.Size(38, 29);
            this.buttonRR_90.TabIndex = 11;
            this.buttonRR_90.Text = "90°";
            this.buttonRR_90.UseVisualStyleBackColor = true;
            this.buttonRR_90.Click += new System.EventHandler(this.buttonRR_90_Click);
            // 
            // buttonRR_180
            // 
            this.buttonRR_180.Location = new System.Drawing.Point(64, 278);
            this.buttonRR_180.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRR_180.Name = "buttonRR_180";
            this.buttonRR_180.Size = new System.Drawing.Size(38, 29);
            this.buttonRR_180.TabIndex = 12;
            this.buttonRR_180.Text = "180°";
            this.buttonRR_180.UseVisualStyleBackColor = true;
            this.buttonRR_180.Click += new System.EventHandler(this.buttonRR_180_Click);
            // 
            // buttonRR_270
            // 
            this.buttonRR_270.Location = new System.Drawing.Point(22, 278);
            this.buttonRR_270.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonRR_270.Name = "buttonRR_270";
            this.buttonRR_270.Size = new System.Drawing.Size(38, 29);
            this.buttonRR_270.TabIndex = 13;
            this.buttonRR_270.Text = "270°";
            this.buttonRR_270.UseVisualStyleBackColor = true;
            this.buttonRR_270.Click += new System.EventHandler(this.buttonRR_270_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(98, 527);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(74, 23);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(50, 34);
            this.labelResolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(75, 13);
            this.labelResolution.TabIndex = 15;
            this.labelResolution.Text = "Rozdzielczość";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(2, 642);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // labelResolutionHeight
            // 
            this.labelResolutionHeight.AutoSize = true;
            this.labelResolutionHeight.Location = new System.Drawing.Point(58, 56);
            this.labelResolutionHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResolutionHeight.Name = "labelResolutionHeight";
            this.labelResolutionHeight.Size = new System.Drawing.Size(60, 13);
            this.labelResolutionHeight.TabIndex = 18;
            this.labelResolutionHeight.Text = "Wysokość:";
            // 
            // labelResolutionWidth
            // 
            this.labelResolutionWidth.AutoSize = true;
            this.labelResolutionWidth.Location = new System.Drawing.Point(58, 94);
            this.labelResolutionWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResolutionWidth.Name = "labelResolutionWidth";
            this.labelResolutionWidth.Size = new System.Drawing.Size(57, 13);
            this.labelResolutionWidth.TabIndex = 19;
            this.labelResolutionWidth.Text = "Szerokość";
            // 
            // numericResolutionHeight
            // 
            this.numericResolutionHeight.Location = new System.Drawing.Point(30, 71);
            this.numericResolutionHeight.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericResolutionHeight.Maximum = new decimal(new int[] {
            1175,
            0,
            0,
            0});
            this.numericResolutionHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericResolutionHeight.Name = "numericResolutionHeight";
            this.numericResolutionHeight.Size = new System.Drawing.Size(120, 20);
            this.numericResolutionHeight.TabIndex = 20;
            this.numericResolutionHeight.Value = new decimal(new int[] {
            1175,
            0,
            0,
            0});
            // 
            // numericResolutionWidth
            // 
            this.numericResolutionWidth.Location = new System.Drawing.Point(30, 110);
            this.numericResolutionWidth.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.numericResolutionWidth.Maximum = new decimal(new int[] {
            850,
            0,
            0,
            0});
            this.numericResolutionWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericResolutionWidth.Name = "numericResolutionWidth";
            this.numericResolutionWidth.Size = new System.Drawing.Size(120, 20);
            this.numericResolutionWidth.TabIndex = 21;
            this.numericResolutionWidth.Value = new decimal(new int[] {
            850,
            0,
            0,
            0});
            // 
            // labelScaningType
            // 
            this.labelScaningType.AutoSize = true;
            this.labelScaningType.Location = new System.Drawing.Point(42, 141);
            this.labelScaningType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelScaningType.Name = "labelScaningType";
            this.labelScaningType.Size = new System.Drawing.Size(85, 13);
            this.labelScaningType.TabIndex = 22;
            this.labelScaningType.Text = "Typ skanowania";
            // 
            // domainScaningSelector
            // 
            this.domainScaningSelector.Items.Add("Skanowanie Czarno-Białe");
            this.domainScaningSelector.Items.Add("Kolorowe");
            this.domainScaningSelector.Location = new System.Drawing.Point(10, 158);
            this.domainScaningSelector.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.domainScaningSelector.Name = "domainScaningSelector";
            this.domainScaningSelector.Size = new System.Drawing.Size(162, 20);
            this.domainScaningSelector.TabIndex = 23;
            this.domainScaningSelector.Text = "Tryb skanowania";
            // 
            // labelSaveFileType
            // 
            this.labelSaveFileType.AutoSize = true;
            this.labelSaveFileType.Location = new System.Drawing.Point(26, 192);
            this.labelSaveFileType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSaveFileType.Name = "labelSaveFileType";
            this.labelSaveFileType.Size = new System.Drawing.Size(116, 13);
            this.labelSaveFileType.TabIndex = 24;
            this.labelSaveFileType.Text = "Typ pliku Wyjściowego";
            // 
            // domainFormatSelector
            // 
            this.domainFormatSelector.Items.Add("JPG");
            this.domainFormatSelector.Items.Add("PNG");
            this.domainFormatSelector.Items.Add("TIFF");
            this.domainFormatSelector.Items.Add("BMP");
            this.domainFormatSelector.Items.Add("REL");
            this.domainFormatSelector.Location = new System.Drawing.Point(30, 217);
            this.domainFormatSelector.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.domainFormatSelector.Name = "domainFormatSelector";
            this.domainFormatSelector.Size = new System.Drawing.Size(120, 20);
            this.domainFormatSelector.TabIndex = 25;
            this.domainFormatSelector.Text = "Format";
            // 
            // pictureBoxScan
            // 
            this.pictureBoxScan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxScan.BackgroundImage")));
            this.pictureBoxScan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxScan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxScan.Location = new System.Drawing.Point(194, 8);
            this.pictureBoxScan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxScan.Name = "pictureBoxScan";
            this.pictureBoxScan.Size = new System.Drawing.Size(543, 622);
            this.pictureBoxScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScan.TabIndex = 26;
            this.pictureBoxScan.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Kontrast";
            // 
            // labelSkanerName
            // 
            this.labelSkanerName.AutoSize = true;
            this.labelSkanerName.Location = new System.Drawing.Point(27, 574);
            this.labelSkanerName.Name = "labelSkanerName";
            this.labelSkanerName.Size = new System.Drawing.Size(125, 13);
            this.labelSkanerName.TabIndex = 28;
            this.labelSkanerName.Text = "Połączono ze skanerem:";
            // 
            // SkanerName
            // 
            this.SkanerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.SkanerName.Location = new System.Drawing.Point(19, 599);
            this.SkanerName.Name = "SkanerName";
            this.SkanerName.Size = new System.Drawing.Size(160, 31);
            this.SkanerName.TabIndex = 29;
            this.SkanerName.Text = "BRAK";
            this.SkanerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Location = new System.Drawing.Point(12, 403);
            this.trackBarBrightness.Maximum = 1000;
            this.trackBarBrightness.Minimum = -1000;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(160, 45);
            this.trackBarBrightness.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Jasność";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(10, 467);
            this.trackBarContrast.Maximum = 1000;
            this.trackBarContrast.Minimum = -1000;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(162, 45);
            this.trackBarContrast.TabIndex = 32;
            // 
            // SkaningMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 642);
            this.Controls.Add(this.trackBarContrast);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.SkanerName);
            this.Controls.Add(this.labelSkanerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxScan);
            this.Controls.Add(this.domainFormatSelector);
            this.Controls.Add(this.labelSaveFileType);
            this.Controls.Add(this.domainScaningSelector);
            this.Controls.Add(this.labelScaningType);
            this.Controls.Add(this.numericResolutionWidth);
            this.Controls.Add(this.numericResolutionHeight);
            this.Controls.Add(this.labelResolutionWidth);
            this.Controls.Add(this.labelResolutionHeight);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRR_270);
            this.Controls.Add(this.buttonRR_180);
            this.Controls.Add(this.buttonRR_90);
            this.Controls.Add(this.buttonRL_270);
            this.Controls.Add(this.buttonRL_90);
            this.Controls.Add(this.labelRotationRight);
            this.Controls.Add(this.labelRotationLeft);
            this.Controls.Add(this.buttonRL_180);
            this.Controls.Add(this.buttonScan);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SkaningMode";
            this.Text = "Skaner";
            this.Load += new System.EventHandler(this.SkaningMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericResolutionHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResolutionWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonRL_180;
        private System.Windows.Forms.Label labelRotationLeft;
        private System.Windows.Forms.Label labelRotationRight;
        private System.Windows.Forms.Button buttonRL_90;
        private System.Windows.Forms.Button buttonRL_270;
        private System.Windows.Forms.Button buttonRR_90;
        private System.Windows.Forms.Button buttonRR_180;
        private System.Windows.Forms.Button buttonRR_270;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label labelResolutionHeight;
        private System.Windows.Forms.Label labelResolutionWidth;
        private System.Windows.Forms.NumericUpDown numericResolutionHeight;
        private System.Windows.Forms.NumericUpDown numericResolutionWidth;
        private System.Windows.Forms.Label labelScaningType;
        private System.Windows.Forms.DomainUpDown domainScaningSelector;
        private System.Windows.Forms.Label labelSaveFileType;
        private System.Windows.Forms.DomainUpDown domainFormatSelector;
        private System.Windows.Forms.PictureBox pictureBoxScan;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSkanerName;
        private System.Windows.Forms.Label SkanerName;
        private System.Windows.Forms.TrackBar trackBarBrightness;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarContrast;
    }
}


