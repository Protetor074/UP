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
            this.folderBrowserSavingFile = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericResolutionHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResolutionWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(19, 758);
            this.buttonScan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(149, 44);
            this.buttonScan.TabIndex = 0;
            this.buttonScan.Text = "Skanuj";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // buttonRL_180
            // 
            this.buttonRL_180.Location = new System.Drawing.Point(132, 642);
            this.buttonRL_180.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonRL_180.Name = "buttonRL_180";
            this.buttonRL_180.Size = new System.Drawing.Size(77, 56);
            this.buttonRL_180.TabIndex = 5;
            this.buttonRL_180.Text = "180°";
            this.buttonRL_180.UseVisualStyleBackColor = true;
            this.buttonRL_180.Click += new System.EventHandler(this.buttonRL_180_Click);
            // 
            // labelRotationLeft
            // 
            this.labelRotationLeft.AutoSize = true;
            this.labelRotationLeft.Location = new System.Drawing.Point(101, 611);
            this.labelRotationLeft.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRotationLeft.Name = "labelRotationLeft";
            this.labelRotationLeft.Size = new System.Drawing.Size(136, 25);
            this.labelRotationLeft.TabIndex = 7;
            this.labelRotationLeft.Text = "Obrót w lewo";
            // 
            // labelRotationRight
            // 
            this.labelRotationRight.AutoSize = true;
            this.labelRotationRight.Location = new System.Drawing.Point(100, 504);
            this.labelRotationRight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelRotationRight.Name = "labelRotationRight";
            this.labelRotationRight.Size = new System.Drawing.Size(150, 25);
            this.labelRotationRight.TabIndex = 8;
            this.labelRotationRight.Text = "Obrót w prawo";
            // 
            // buttonRL_90
            // 
            this.buttonRL_90.Location = new System.Drawing.Point(221, 642);
            this.buttonRL_90.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonRL_90.Name = "buttonRL_90";
            this.buttonRL_90.Size = new System.Drawing.Size(77, 56);
            this.buttonRL_90.TabIndex = 9;
            this.buttonRL_90.Text = "90°";
            this.buttonRL_90.UseVisualStyleBackColor = true;
            this.buttonRL_90.Click += new System.EventHandler(this.buttonRL_90_Click);
            // 
            // buttonRL_270
            // 
            this.buttonRL_270.Location = new System.Drawing.Point(43, 642);
            this.buttonRL_270.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonRL_270.Name = "buttonRL_270";
            this.buttonRL_270.Size = new System.Drawing.Size(77, 56);
            this.buttonRL_270.TabIndex = 10;
            this.buttonRL_270.Text = "270°";
            this.buttonRL_270.UseVisualStyleBackColor = true;
            this.buttonRL_270.Click += new System.EventHandler(this.buttonRL_270_Click);
            // 
            // buttonRR_90
            // 
            this.buttonRR_90.Location = new System.Drawing.Point(221, 535);
            this.buttonRR_90.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonRR_90.Name = "buttonRR_90";
            this.buttonRR_90.Size = new System.Drawing.Size(77, 56);
            this.buttonRR_90.TabIndex = 11;
            this.buttonRR_90.Text = "90°";
            this.buttonRR_90.UseVisualStyleBackColor = true;
            this.buttonRR_90.Click += new System.EventHandler(this.buttonRR_90_Click);
            // 
            // buttonRR_180
            // 
            this.buttonRR_180.Location = new System.Drawing.Point(128, 535);
            this.buttonRR_180.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonRR_180.Name = "buttonRR_180";
            this.buttonRR_180.Size = new System.Drawing.Size(77, 56);
            this.buttonRR_180.TabIndex = 12;
            this.buttonRR_180.Text = "180°";
            this.buttonRR_180.UseVisualStyleBackColor = true;
            this.buttonRR_180.Click += new System.EventHandler(this.buttonRR_180_Click);
            // 
            // buttonRR_270
            // 
            this.buttonRR_270.Location = new System.Drawing.Point(43, 535);
            this.buttonRR_270.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonRR_270.Name = "buttonRR_270";
            this.buttonRR_270.Size = new System.Drawing.Size(77, 56);
            this.buttonRR_270.TabIndex = 13;
            this.buttonRR_270.Text = "270°";
            this.buttonRR_270.UseVisualStyleBackColor = true;
            this.buttonRR_270.Click += new System.EventHandler(this.buttonRR_270_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(192, 758);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(149, 44);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Location = new System.Drawing.Point(101, 65);
            this.labelResolution.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(151, 25);
            this.labelResolution.TabIndex = 15;
            this.labelResolution.Text = "Rozdzielczość";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 1041);
            this.splitter1.TabIndex = 16;
            this.splitter1.TabStop = false;
            // 
            // labelResolutionHeight
            // 
            this.labelResolutionHeight.AutoSize = true;
            this.labelResolutionHeight.Location = new System.Drawing.Point(117, 108);
            this.labelResolutionHeight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelResolutionHeight.Name = "labelResolutionHeight";
            this.labelResolutionHeight.Size = new System.Drawing.Size(117, 25);
            this.labelResolutionHeight.TabIndex = 18;
            this.labelResolutionHeight.Text = "Wysokość:";
            // 
            // labelResolutionWidth
            // 
            this.labelResolutionWidth.AutoSize = true;
            this.labelResolutionWidth.Location = new System.Drawing.Point(117, 181);
            this.labelResolutionWidth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelResolutionWidth.Name = "labelResolutionWidth";
            this.labelResolutionWidth.Size = new System.Drawing.Size(113, 25);
            this.labelResolutionWidth.TabIndex = 19;
            this.labelResolutionWidth.Text = "Szerokość";
            // 
            // numericResolutionHeight
            // 
            this.numericResolutionHeight.Location = new System.Drawing.Point(60, 136);
            this.numericResolutionHeight.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericResolutionHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericResolutionHeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericResolutionHeight.Name = "numericResolutionHeight";
            this.numericResolutionHeight.Size = new System.Drawing.Size(240, 31);
            this.numericResolutionHeight.TabIndex = 20;
            this.numericResolutionHeight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericResolutionHeight.ValueChanged += new System.EventHandler(this.numericResolutionHeight_ValueChanged);
            // 
            // numericResolutionWidth
            // 
            this.numericResolutionWidth.Location = new System.Drawing.Point(60, 211);
            this.numericResolutionWidth.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.numericResolutionWidth.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericResolutionWidth.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericResolutionWidth.Name = "numericResolutionWidth";
            this.numericResolutionWidth.Size = new System.Drawing.Size(240, 31);
            this.numericResolutionWidth.TabIndex = 21;
            this.numericResolutionWidth.Value = new decimal(new int[] {
            700,
            0,
            0,
            0});
            // 
            // labelScaningType
            // 
            this.labelScaningType.AutoSize = true;
            this.labelScaningType.Location = new System.Drawing.Point(83, 272);
            this.labelScaningType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelScaningType.Name = "labelScaningType";
            this.labelScaningType.Size = new System.Drawing.Size(168, 25);
            this.labelScaningType.TabIndex = 22;
            this.labelScaningType.Text = "Typ skanowania";
            // 
            // domainScaningSelector
            // 
            this.domainScaningSelector.Items.Add("Skanowanie Czarno-Białe");
            this.domainScaningSelector.Items.Add("Kolorowe");
            this.domainScaningSelector.Location = new System.Drawing.Point(19, 304);
            this.domainScaningSelector.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.domainScaningSelector.Name = "domainScaningSelector";
            this.domainScaningSelector.Size = new System.Drawing.Size(324, 31);
            this.domainScaningSelector.TabIndex = 23;
            this.domainScaningSelector.Text = "Tryb skanowania";
            // 
            // labelSaveFileType
            // 
            this.labelSaveFileType.AutoSize = true;
            this.labelSaveFileType.Location = new System.Drawing.Point(53, 369);
            this.labelSaveFileType.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSaveFileType.Name = "labelSaveFileType";
            this.labelSaveFileType.Size = new System.Drawing.Size(231, 25);
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
            this.domainFormatSelector.Location = new System.Drawing.Point(60, 418);
            this.domainFormatSelector.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.domainFormatSelector.Name = "domainFormatSelector";
            this.domainFormatSelector.Size = new System.Drawing.Size(240, 31);
            this.domainFormatSelector.TabIndex = 25;
            this.domainFormatSelector.Text = "Format";
            this.domainFormatSelector.SelectedItemChanged += new System.EventHandler(this.domainFormatSelector_SelectedItemChanged);
            // 
            // pictureBoxScan
            // 
            this.pictureBoxScan.Location = new System.Drawing.Point(389, 15);
            this.pictureBoxScan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.pictureBoxScan.Name = "pictureBoxScan";
            this.pictureBoxScan.Size = new System.Drawing.Size(820, 1002);
            this.pictureBoxScan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScan.TabIndex = 26;
            this.pictureBoxScan.TabStop = false;
            this.pictureBoxScan.Click += new System.EventHandler(this.pictureBoxScan_Click);
            // 
            // SkaningMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 1041);
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
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SkaningMode";
            this.Text = "Skaner";
            this.Load += new System.EventHandler(this.SkaningMode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericResolutionHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericResolutionWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScan)).EndInit();
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
        private System.Windows.Forms.FolderBrowserDialog folderBrowserSavingFile;
    }
}

