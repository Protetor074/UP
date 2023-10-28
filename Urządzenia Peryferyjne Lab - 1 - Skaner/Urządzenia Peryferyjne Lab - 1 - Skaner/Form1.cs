using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WIA;



namespace Urządzenia_Peryferyjne_Lab___1___Skaner
{
    public partial class SkaningMode : Form
    {

        Image obraz;
        ImageFile imgFile;
        Device device;
        WIA.Item scannerItem;
        string wiaFormatJPG = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}";
        string wiaFormatBMP = "{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}";
        string wiaFormatPNG = "{b96b3caf-0728-11d3-9d7b-0000f81ef32e}";
        string wiaFormatTIFF = "{b96b3cb1-0728-11d3-9d7b-0000f81ef32e}";

        public SkaningMode()
        {
            InitializeComponent();
        }

        //Konwersja
        static Image ConvertImageFileToImage(ImageFile imageFile)
        {
            // Pobierz dane obrazu jako tablicę bajtów
            byte[] imageBytes = (byte[])imageFile.FileData.get_BinaryData();

            // Utwórz strumień pamięci na podstawie tablicy bajtów
            using (MemoryStream stream = new MemoryStream(imageBytes))
            {
                // Utwórz obiekt Image na podstawie strumienia
                Image obraz = Image.FromStream(stream);
                return obraz;
            }
        }

        //zapis do pliku
        static void SaveImageFile(ImageFile imageFile, string filePath)
        {
            // Uzyskaj dane obrazu jako tablicę bajtów
            byte[] imageBytes = (byte[])imageFile.FileData.get_BinaryData();

            // Zapisz tablicę bajtów do pliku
            System.IO.File.WriteAllBytes(filePath, imageBytes);
        }

        private void buttonScan_Click(object sender, EventArgs e)
        {
             int color = domainScaningSelector.SelectedIndex;
             if (color == -1) {
                 MessageBox.Show("Nie wybrano trybu skanowania.");
                 return;
             }

             DeviceManager deviceManager = new DeviceManager();
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
                SkanerName.Text = firstScanner.Properties["Name"].get_Value();
                try
                {
                    device = firstScanner.Connect();
                }catch(System.Runtime.InteropServices.COMException ex)
                {
                    MessageBox.Show("Błąd połączenia ze skanerem.");
                    return;
                }
               
                scannerItem = device.Items[1] as WIA.Item;        

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
                int brightness = trackBarBrightness.Value;
                int contrast  = trackBarContrast.Value;

                //scannerItem.Properties["6147"].set_Value(600);//DPI- 600   

                scannerItem.Properties["Horizontal Start Position"].set_Value(1);
                scannerItem.Properties["Horizontal Start Position"].set_Value(1);
                scannerItem.Properties["Horizontal Resolution"].set_Value(100);
                scannerItem.Properties["Vertical Resolution"].set_Value(100);
                scannerItem.Properties["Horizontal Extent"].set_Value(width);
                scannerItem.Properties["Vertical Extent"].set_Value(hight);
                scannerItem.Properties["Format"].set_Value(wiaFormatBMP);
                scannerItem.Properties["Brightness"].set_Value(brightness);
                scannerItem.Properties["Contrast"].set_Value(contrast);

                //Wyświetlenie wszystkich właśiwości
                /*foreach (Property property in scannerItem.Properties) {
                     Console.WriteLine($"Nazwa właściwości: {property.Name}");
                     Console.WriteLine($"Typ Danych: {property.Type}");
                     Console.WriteLine($"Wartość:{property.get_Value()}");
                     Console.WriteLine();
                 }*/

                //Skanowanie
                imgFile = (ImageFile)scannerItem.Transfer(wiaFormatJPG);
                obraz = ConvertImageFileToImage(imgFile);
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
            if (domainScaningSelector.SelectedIndex == -1)
            {
                MessageBox.Show("Nie wybrano trybu skanowania.");
                return;
            }
            int code = domainFormatSelector.SelectedIndex;
            switch (code)
            {
                case -1:
                    MessageBox.Show("Wystąpił błąd: Nie wybrano formatu");
                    break;
                case 0://JPG
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sciezkaDoPliku = saveFileDialog.FileName;
                        sciezkaDoPliku = sciezkaDoPliku + ".jpg";
                        imgFile = (ImageFile)scannerItem.Transfer(wiaFormatJPG);
                        SaveImageFile(imgFile, sciezkaDoPliku);

                        MessageBox.Show("Obraz zapisany");
                    }
                    break;
                case 1://PNG
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sciezkaDoPliku = saveFileDialog.FileName;
                        sciezkaDoPliku = sciezkaDoPliku + ".png";
                        imgFile = (ImageFile)scannerItem.Transfer(wiaFormatPNG);
                        SaveImageFile(imgFile, sciezkaDoPliku);

                        MessageBox.Show("Obraz zapisany");
                    }
                    break;
                case 2://TIFF
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sciezkaDoPliku = saveFileDialog.FileName;
                        sciezkaDoPliku = sciezkaDoPliku + ".tif";
                        imgFile = (ImageFile)scannerItem.Transfer(wiaFormatTIFF);
                        SaveImageFile(imgFile, sciezkaDoPliku);

                        MessageBox.Show("Obraz zapisany");
                    }
                    break;
                case 3://BMP
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string sciezkaDoPliku = saveFileDialog.FileName;
                        sciezkaDoPliku = sciezkaDoPliku + ".bmp";
                        imgFile = (ImageFile)scannerItem.Transfer(wiaFormatBMP);
                        SaveImageFile(imgFile, sciezkaDoPliku);
                        MessageBox.Show("Obraz zapisany");
                    }
                    break;
            }
        }
        private void SkaningMode_Load(object sender, EventArgs e)
        {

        }
    }
}
