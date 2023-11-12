namespace Urządzenia_Peryferyjne_Lab___1___Kamera_internetowa
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonConectCamera = new System.Windows.Forms.Button();
            this.buttonTurnOffCamera = new System.Windows.Forms.Button();
            this.buttonTakePhoto = new System.Windows.Forms.Button();
            this.myPictureBoxCamera = new System.Windows.Forms.PictureBox();
            this.myPictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.buttonSavePhoto = new System.Windows.Forms.Button();
            this.saveFileDialogPhoto = new System.Windows.Forms.SaveFileDialog();
            this.buttonStartRecord = new System.Windows.Forms.Button();
            this.buttonStopRecord = new System.Windows.Forms.Button();
            this.saveFileDialogMovie = new System.Windows.Forms.SaveFileDialog();
            this.buttonMotionDetect = new System.Windows.Forms.Button();
            this.buttonStopDetectMotion = new System.Windows.Forms.Button();
            this.numericUpDownMoutionDetectionVal = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMoutionDetect = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBoxCamera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBoxPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoutionDetectionVal)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConectCamera
            // 
            this.buttonConectCamera.Location = new System.Drawing.Point(12, 12);
            this.buttonConectCamera.Name = "buttonConectCamera";
            this.buttonConectCamera.Size = new System.Drawing.Size(114, 23);
            this.buttonConectCamera.TabIndex = 1;
            this.buttonConectCamera.Text = "Połącz z kamerą";
            this.buttonConectCamera.UseVisualStyleBackColor = true;
            this.buttonConectCamera.Click += new System.EventHandler(this.buttonConectCamera_Click);
            // 
            // buttonTurnOffCamera
            // 
            this.buttonTurnOffCamera.Location = new System.Drawing.Point(12, 41);
            this.buttonTurnOffCamera.Name = "buttonTurnOffCamera";
            this.buttonTurnOffCamera.Size = new System.Drawing.Size(114, 23);
            this.buttonTurnOffCamera.TabIndex = 2;
            this.buttonTurnOffCamera.Text = "Wyłącz kamerę";
            this.buttonTurnOffCamera.UseVisualStyleBackColor = true;
            this.buttonTurnOffCamera.Click += new System.EventHandler(this.buttonTurnOffCamera_Click);
            // 
            // buttonTakePhoto
            // 
            this.buttonTakePhoto.Location = new System.Drawing.Point(12, 70);
            this.buttonTakePhoto.Name = "buttonTakePhoto";
            this.buttonTakePhoto.Size = new System.Drawing.Size(114, 23);
            this.buttonTakePhoto.TabIndex = 3;
            this.buttonTakePhoto.Text = "Zrób zdjęcie";
            this.buttonTakePhoto.UseVisualStyleBackColor = true;
            this.buttonTakePhoto.Click += new System.EventHandler(this.buttonTakePhoto_Click);
            // 
            // myPictureBoxCamera
            // 
            this.myPictureBoxCamera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myPictureBoxCamera.BackgroundImage")));
            this.myPictureBoxCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myPictureBoxCamera.Location = new System.Drawing.Point(149, 12);
            this.myPictureBoxCamera.Name = "myPictureBoxCamera";
            this.myPictureBoxCamera.Size = new System.Drawing.Size(366, 329);
            this.myPictureBoxCamera.TabIndex = 4;
            this.myPictureBoxCamera.TabStop = false;
            // 
            // myPictureBoxPhoto
            // 
            this.myPictureBoxPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("myPictureBoxPhoto.BackgroundImage")));
            this.myPictureBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.myPictureBoxPhoto.Location = new System.Drawing.Point(536, 12);
            this.myPictureBoxPhoto.Name = "myPictureBoxPhoto";
            this.myPictureBoxPhoto.Size = new System.Drawing.Size(366, 329);
            this.myPictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPictureBoxPhoto.TabIndex = 5;
            this.myPictureBoxPhoto.TabStop = false;
            // 
            // buttonSavePhoto
            // 
            this.buttonSavePhoto.Location = new System.Drawing.Point(12, 99);
            this.buttonSavePhoto.Name = "buttonSavePhoto";
            this.buttonSavePhoto.Size = new System.Drawing.Size(114, 23);
            this.buttonSavePhoto.TabIndex = 6;
            this.buttonSavePhoto.Text = "Zapisz zdjęcie";
            this.buttonSavePhoto.UseVisualStyleBackColor = true;
            this.buttonSavePhoto.Click += new System.EventHandler(this.buttonSavePhoto_Click);
            // 
            // buttonStartRecord
            // 
            this.buttonStartRecord.Location = new System.Drawing.Point(12, 128);
            this.buttonStartRecord.Name = "buttonStartRecord";
            this.buttonStartRecord.Size = new System.Drawing.Size(114, 23);
            this.buttonStartRecord.TabIndex = 7;
            this.buttonStartRecord.Text = "Nagraj Film";
            this.buttonStartRecord.UseVisualStyleBackColor = true;
            this.buttonStartRecord.Click += new System.EventHandler(this.buttonStartRecord_Click);
            // 
            // buttonStopRecord
            // 
            this.buttonStopRecord.Location = new System.Drawing.Point(13, 158);
            this.buttonStopRecord.Name = "buttonStopRecord";
            this.buttonStopRecord.Size = new System.Drawing.Size(113, 23);
            this.buttonStopRecord.TabIndex = 8;
            this.buttonStopRecord.Text = "Zakończ Nagranie";
            this.buttonStopRecord.UseVisualStyleBackColor = true;
            this.buttonStopRecord.Click += new System.EventHandler(this.buttonStopRecord_Click);
            // 
            // buttonMotionDetect
            // 
            this.buttonMotionDetect.Location = new System.Drawing.Point(13, 187);
            this.buttonMotionDetect.Name = "buttonMotionDetect";
            this.buttonMotionDetect.Size = new System.Drawing.Size(113, 23);
            this.buttonMotionDetect.TabIndex = 9;
            this.buttonMotionDetect.Text = "Wykrywanie Ruchu";
            this.buttonMotionDetect.UseVisualStyleBackColor = true;
            this.buttonMotionDetect.Click += new System.EventHandler(this.buttonMotionDetect_Click);
            // 
            // buttonStopDetectMotion
            // 
            this.buttonStopDetectMotion.Location = new System.Drawing.Point(13, 217);
            this.buttonStopDetectMotion.Name = "buttonStopDetectMotion";
            this.buttonStopDetectMotion.Size = new System.Drawing.Size(113, 46);
            this.buttonStopDetectMotion.TabIndex = 10;
            this.buttonStopDetectMotion.Text = "Zatrzymaj wykrywanie ruchu";
            this.buttonStopDetectMotion.UseVisualStyleBackColor = true;
            this.buttonStopDetectMotion.Click += new System.EventHandler(this.buttonStopDetectMotion_Click);
            // 
            // numericUpDownMoutionDetectionVal
            // 
            this.numericUpDownMoutionDetectionVal.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownMoutionDetectionVal.Location = new System.Drawing.Point(37, 287);
            this.numericUpDownMoutionDetectionVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMoutionDetectionVal.Name = "numericUpDownMoutionDetectionVal";
            this.numericUpDownMoutionDetectionVal.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownMoutionDetectionVal.TabIndex = 11;
            this.numericUpDownMoutionDetectionVal.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Poziom wykrywania:";
            // 
            // labelMoutionDetect
            // 
            this.labelMoutionDetect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMoutionDetect.Location = new System.Drawing.Point(13, 310);
            this.labelMoutionDetect.Name = "labelMoutionDetect";
            this.labelMoutionDetect.Size = new System.Drawing.Size(113, 31);
            this.labelMoutionDetect.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 355);
            this.Controls.Add(this.labelMoutionDetect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownMoutionDetectionVal);
            this.Controls.Add(this.buttonStopDetectMotion);
            this.Controls.Add(this.buttonMotionDetect);
            this.Controls.Add(this.buttonStopRecord);
            this.Controls.Add(this.buttonStartRecord);
            this.Controls.Add(this.buttonSavePhoto);
            this.Controls.Add(this.myPictureBoxPhoto);
            this.Controls.Add(this.myPictureBoxCamera);
            this.Controls.Add(this.buttonTakePhoto);
            this.Controls.Add(this.buttonTurnOffCamera);
            this.Controls.Add(this.buttonConectCamera);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBoxCamera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myPictureBoxPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMoutionDetectionVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConectCamera;
        private System.Windows.Forms.Button buttonTurnOffCamera;
        private System.Windows.Forms.Button buttonTakePhoto;
        private System.Windows.Forms.PictureBox myPictureBoxCamera;
        private System.Windows.Forms.PictureBox myPictureBoxPhoto;
        private System.Windows.Forms.Button buttonSavePhoto;
        private System.Windows.Forms.SaveFileDialog saveFileDialogPhoto;
        private System.Windows.Forms.Button buttonStartRecord;
        private System.Windows.Forms.Button buttonStopRecord;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMovie;
        private System.Windows.Forms.Button buttonMotionDetect;
        private System.Windows.Forms.Button buttonStopDetectMotion;
        private System.Windows.Forms.NumericUpDown numericUpDownMoutionDetectionVal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelMoutionDetect;
    }
}

