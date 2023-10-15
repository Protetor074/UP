using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Urządzenia_Peryferyjne_Lab___1___Skaner
{
    public partial class SkaningMode : Form
    {
        Image obraz;
        public SkaningMode()
        {
            InitializeComponent();
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            obraz = new Bitmap("s1.bmp");
            pictureBoxScan.Image = obraz;
        }

        private void buttonRR_90_Click(object sender, EventArgs e)
        {
            if(obraz != null)
            {
                obraz.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBoxScan.Image = obraz;
            }
        }

        private void buttonRR_180_Click(object sender, EventArgs e)
        {
            obraz.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBoxScan.Image = obraz;
        }

        private void buttonRR_270_Click(object sender, EventArgs e)
        {
            obraz.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBoxScan.Image = obraz;
        }

        private void buttonRL_90_Click(object sender, EventArgs e)
        {
            obraz.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBoxScan.Image = obraz;
        }

        private void buttonRL_180_Click(object sender, EventArgs e)
        {
            obraz.RotateFlip(RotateFlipType.Rotate180FlipNone);
            pictureBoxScan.Image = obraz;
        }

        private void buttonRL_270_Click(object sender, EventArgs e)
        {
            obraz.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBoxScan.Image = obraz;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int code = domainFormatSelector.SelectedIndex;
            Console.WriteLine(code);
            switch (code)
            {
                case -1:
                    MessageBox.Show("Wystąpił błąd: Nie wybrano formatu");
                    break;
                case 0://JPG
                    if (folderBrowserSavingFile.ShowDialog() == DialogResult.OK)
                    {
                        string sciezkaDoFolderu = folderBrowserSavingFile.SelectedPath;
                        Console.WriteLine(sciezkaDoFolderu);
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            obraz.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] bytes = memoryStream.ToArray();
                            File.WriteAllBytes("obraz.jpg", bytes);
                        }
                        MessageBox.Show("Obraz zapisany");

                    }
                    break;
                case 1://PNG
                    break;
                case 2://TIFF
                    break;
                case 3://BMP
                    break;
                case 4://REL
                    break;
            }
        }
        // Metoda do uzyskania kodera dla określonego formatu obrazu
        private static ImageCodecInfo GetEncoderInfo(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
