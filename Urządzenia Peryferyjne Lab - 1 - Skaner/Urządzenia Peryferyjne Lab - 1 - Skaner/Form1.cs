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
using WIA;



namespace Urządzenia_Peryferyjne_Lab___1___Skaner
{
    public partial class SkaningMode : Form
    {

        Image obraz;
        public SkaningMode()
        {
            InitializeComponent();
        }

        private void scan() {

        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
            const string wiaFormatJPEG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";

            int color = domainScaningSelector.SelectedIndex;
            if (color == -1) {
                MessageBox.Show("Nie wybrano trybu skanowania.");
                return;
            }
                  
            var deviceManager = new DeviceManager();
            DeviceInfo firstScanner = null;
            foreach (DeviceInfo deviceInfo in deviceManager.DeviceInfos)
            {
                if (deviceInfo.Type == WiaDeviceType.ScannerDeviceType)
                {
                    firstScanner = deviceInfo;
                    break;
                }
            }

            if (firstScanner != null)
            {
                Console.WriteLine("Znaleziono skaner: " + firstScanner.Properties["Name"].get_Value());

                var device = firstScanner.Connect();
                var scannerItem = device.Items[1] as WIA.Item;
               
                scannerItem.Properties["6147"].set_Value(600);//DPI- 600             

                switch (color) {
                    case 0:
                        scannerItem.Properties["6146"].set_Value(2);//Czarno-Białe
                        break;
                    case 1:
                        scannerItem.Properties["6146"].set_Value(1);//Kolorowe
                        break;
                    
                }

                int hight = (int)numericResolutionHeight.Value;
                int width = (int)numericResolutionWidth.Value;

                scannerItem.Properties["Horizontal Start Position"].set_Value(1);
                scannerItem.Properties["Horizontal Start Position"].set_Value(1);
                scannerItem.Properties["Horizontal Resolution"].set_Value(100);
                scannerItem.Properties["Vertical Resolution"].set_Value(90);
                scannerItem.Properties["Horizontal Extent"].set_Value(700);
                scannerItem.Properties["Vertical Extent"].set_Value(hight);


                foreach (Property property in scannerItem.Properties) {
                    Console.WriteLine($"Nazwa właściwości: {property.Name}");
                    Console.WriteLine($"Typ Danych: {property.Type}");
                    Console.WriteLine($"Wartość:{property.get_Value()}");
                    Console.WriteLine();
                }

                var imgFile = (ImageFile)scannerItem.Transfer(wiaFormatJPEG);
                using (MemoryStream stream = new MemoryStream((byte[])imgFile.FileData.get_BinaryData())) {
                    obraz = Image.FromStream(stream);
                }
                    
                    Console.WriteLine("Obraz został pomyślnie zeskanowany i zapisany jako skan.jpg");
            }
            else
            {
                Console.WriteLine("Nie znaleziono urządzenia skanującego.");
            }

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
                    if (folderBrowserSavingFile.ShowDialog() == DialogResult.OK)
                    {
                        string sciezkaDoFolderu = folderBrowserSavingFile.SelectedPath;
                        Console.WriteLine(sciezkaDoFolderu);
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            obraz.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                            byte[] bytes = memoryStream.ToArray();
                            File.WriteAllBytes("obraz.png", bytes);
                        }
                        MessageBox.Show("Obraz zapisany");
                    }
                    break;
                case 2://TIFF
                    if (folderBrowserSavingFile.ShowDialog() == DialogResult.OK)
                    {
                        string sciezkaDoFolderu = folderBrowserSavingFile.SelectedPath;
                        Console.WriteLine(sciezkaDoFolderu);
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            obraz.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Tiff);
                            byte[] bytes = memoryStream.ToArray();
                            File.WriteAllBytes("obraz.tiff", bytes);
                        }
                        MessageBox.Show("Obraz zapisany");
                    }
                    break;
                case 3://BMP
                    if (folderBrowserSavingFile.ShowDialog() == DialogResult.OK)
                    {
                        string sciezkaDoFolderu = folderBrowserSavingFile.SelectedPath;
                        Console.WriteLine(sciezkaDoFolderu);
                        using (MemoryStream memoryStream = new MemoryStream())
                        {
                            obraz.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Bmp);
                            byte[] bytes = memoryStream.ToArray();
                            File.WriteAllBytes("obraz.bmp", bytes);
                        }
                        MessageBox.Show("Obraz zapisany");
                    }
                    break;
                case 4://REL
                    break;
            }
        }
        private void SkaningMode_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxScan_Click(object sender, EventArgs e) {

        }

        private void numericResolutionHeight_ValueChanged(object sender, EventArgs e) {

        }

        private void domainFormatSelector_SelectedItemChanged(object sender, EventArgs e) {

        }
    }
}
