using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using System.Runtime.InteropServices;
using Vanara.Extensions.Reflection;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Collections;
using Vanara.PInvoke;
using System.IO;

namespace Urządzenia_Peryferyjne_Lab___1___Kamera_internetowa
{
    public partial class Form1 : Form
    {
        WebCamControl cam = new WebCamControl();
        Bitmap currentImage;

        public Form1()
        {
            InitializeComponent();
            buttonTurnOffCamera.Enabled = false;
            buttonTakePhoto.Enabled = false;
            buttonSavePhoto.Enabled = false;
            buttonStartRecord.Enabled = false;
            buttonStopRecord.Enabled = false;
            buttonMotionDetect.Enabled = false;
            buttonStopDetectMotion.Enabled = false;
        }

        private void buttonConectCamera_Click(object sender, EventArgs e)
        {
            cam.Load();
            cam.OpenConnection(myPictureBoxCamera);

            buttonConectCamera.Enabled = false;
            buttonTurnOffCamera.Enabled = true;
            buttonTakePhoto.Enabled = true;
            buttonStartRecord.Enabled = true;
            buttonMotionDetect.Enabled = true;

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Zatrzymaj podgląd kamery przed zamknięciem formularza
            cam.StopPreview();
            myPictureBoxCamera.Image = Image.FromFile("cam.jpg");
        }

        private void buttonTurnOffCamera_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Kamera Wyłączona");
            cam.StopPreview();

            buttonConectCamera.Enabled = true;
            buttonTurnOffCamera.Enabled = false;
            buttonTakePhoto.Enabled = false;
            buttonStartRecord.Enabled = false;
            buttonStopRecord.Enabled = false;
            buttonMotionDetect.Enabled = false;
            buttonStopDetectMotion.Enabled = false;


        }

        private void buttonTakePhoto_Click(object sender, EventArgs e)
        {
            currentImage = cam.GetCurrentImage();
            myPictureBoxPhoto.Image = currentImage;
            buttonSavePhoto.Enabled = true;
        }

        private void buttonSavePhoto_Click(object sender, EventArgs e)
        {
            saveFileDialogPhoto.Filter = "JPEG Files (*.jpg)|*.jpg|All files (*.*)|*.*"; // Ustaw filtr plików
            saveFileDialogPhoto.Title = "Save an Image File"; // Ustaw tytuł okna dialogowego

            saveFileDialogPhoto.ShowDialog(); //pokazanie okna
            string path = saveFileDialogPhoto.FileName;
            currentImage.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            Console.WriteLine(path);


        }

        private void buttonStartRecord_Click(object sender, EventArgs e)
        {
            cam.StartRecording();
            buttonTurnOffCamera.Enabled = false;
            buttonMotionDetect.Enabled = false;
            buttonTakePhoto.Enabled = false;

            buttonStartRecord.Enabled = false;
            buttonStopRecord.Enabled = true;

        }

        private void buttonStopRecord_Click(object sender, EventArgs e)
        {
            cam.StopRecording(saveFileDialogMovie);
            
            buttonTurnOffCamera.Enabled = true;
            buttonMotionDetect.Enabled = true;
            buttonTakePhoto.Enabled = true;

            buttonStartRecord.Enabled = true;
            buttonStopRecord.Enabled = false;

        }

        private void buttonMotionDetect_Click(object sender, EventArgs e)
        {

            cam.StartMotionDetection((int)numericUpDownMoutionDetectionVal.Value,labelMoutionDetect);
            buttonMotionDetect.Enabled = false;
            buttonStopDetectMotion.Enabled = true;

            buttonTurnOffCamera.Enabled = false;
            buttonStartRecord.Enabled = false;
            buttonTakePhoto.Enabled = false;

            buttonMotionDetect.Enabled = false;
            buttonStopDetectMotion.Enabled = true;
        }

        private void buttonStopDetectMotion_Click(object sender, EventArgs e)
        {
            cam.StopMotionDetection();

            buttonTurnOffCamera.Enabled = true;
            buttonTakePhoto.Enabled = true;
            buttonStartRecord.Enabled = true;

            buttonMotionDetect.Enabled = true;
            buttonStopDetectMotion.Enabled = false;
        }

        public partial class WebCamControl
        {
            // Początkowy kod dla systemu zarządzania przechwytywaniem (Windows Multimedia API).
            private const int WM_CAP_START = 0x400;
            // Okno jest potomkiem, używane jako flaga dla funkcji określającej styl okna.
            private const int WS_CHILD = 0x40000000;
            // Okno jest widoczne, używane jako flaga dla funkcji określającej styl okna.
            private const int WS_VISIBLE = 0x10000000;

            // Żądanie połączenia z urządzeniem do przechwytywania wideo.
            private const int WM_CAP_DRIVER_CONNECT = 0x40a;
            // Żądanie rozłączenia z urządzeniem do przechwytywania wideo.
            private const int WM_CAP_DRIVER_DISCONNECT = 0x40b;
            // Kopiowanie obrazu do schowka.
            private const int WM_CAP_COPY = 0x41e;
            // Rozpoczęcie sekwencji przechwytywania klatek.
            private const int WM_CAP_SEQUENCE = WM_CAP_START + 62;
            // Żądanie zapisania przechwyconego materiału wideo do pliku.
            private const int WM_CAP_FILE_SAVEAS = WM_CAP_START + 23;

            // Ustawienie skali obrazu do podglądu lub przechwytywania.
            private const int WM_CAP_SET_SCALE = 0x435;
            // Ustawienie szybkości podglądu.
            private const int WM_CAP_SET_PREVIEWRATE = 0x434;
            // Włączenie lub wyłączenie podglądu.
            private const int WM_CAP_SET_PREVIEW = 0x432;
            // Pobranie pojedynczej klatki obrazu.
            private const int WM_CAP_GET_FRAME = 1084;

            //private const int WM_CAP_SET_OVERLAY = 0x433;

            // Nie przemieszczaj okna podczas zmiany rozmiaru lub układu.
            private const int SWP_NOMOVE = 0x2;
            // Nie zmieniaj położenia okna w stosunku do innych okien.
            private const int SWP_NOZORDER = 0x4;
            // Okno jest na najniższym poziomie w stosie okien. 
            private const int HWND_BOTTOM = 1;
            



            //This function enables enumerate the web cam devices
            //Ta funkcja umożliwia wyliczenie kamer internetowych
            [DllImport("avicap32.dll")]
            protected static extern bool capGetDriverDescriptionA(short wDriverIndex,
                [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszName,
               int cbName, [MarshalAs(UnmanagedType.VBByRefStr)] ref String lpszVer, int cbVer);

            //This function enables create a  window child with so that you can display it in a picturebox for example
            //Ta funkcja umożliwia utworzenie okna potomnego, dzięki czemu można je wyświetlić na przykład w ramce graficznej
            [DllImport("avicap32.dll")]
            protected static extern int capCreateCaptureWindowA([MarshalAs(UnmanagedType.VBByRefStr)] ref string lpszWindowName,
                int dwStyle, int x, int y, int nWidth, int nHeight, int hWndParent, int nID);
            

            //This function enables set changes to the size, position, and Z order of a child window
            //Ta funkcja umożliwia ustawienie zmian w rozmiarze, położeniu i kolejności Z okna podrzędnego
            [DllImport("user32")]
            protected static extern int SetWindowPos(int hwnd, int hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);

            //This function enables send the specified message to a window or windows
            //Ta funkcja umożliwia wysłanie określonej wiadomości do okna lub okien
            [DllImport("user32", EntryPoint = "SendMessageA")]
            protected static extern int SendMessage(int hwnd, int wMsg, int wParam, [MarshalAs(UnmanagedType.AsAny)] object lParam);

            //This function enable destroy the window child
            ////Ta funkcja umożliwia zniszczenie okna potomnego
            [DllImport("user32")]
            protected static extern bool DestroyWindow(int hwnd);

            // Normal device ID
            private int DeviceID = 0;
            private bool isRecording = false;
            private bool CameraIsActive = false;

            // Uchwyt wartości do okna podglądu
            int hHwnd = 0;
            //Lista urządzeń
            ArrayList ListOfDevices = new ArrayList();

           


            // Połącz się z urządzeniem.
            /// <summary>
            /// Ta funkcja służy do załadowania listy urządzeń
            /// </summary>

            public void Load()
            {
                string Name = String.Empty.PadRight(100);
                string Version = String.Empty.PadRight(100);
                bool moreDevices;
                short index = 0;

                // Załaduj nazwy wszystkich dostępnych urządzeń do lstDevices .
                do
                {
                    // Pobierz nazwę i wersję sterownika
                    moreDevices = capGetDriverDescriptionA(index, ref Name, 100, ref Version, 100);
                    // Jeśli istniało urządzenie, dodaj nazwę urządzenia do listy
                    if (moreDevices)
                        ListOfDevices.Add(Name.Trim());
                        Console.WriteLine(Name.Trim());
                    index += 1;
                }
                while (moreDevices);
            }

            /// <summary>
            /// Funkcja używana do wyświetlania sygnału wyjściowego z urządzenia do przechwytywania wideo, którą należy utworzyć
            /// okno przechwytywania.
            /// </summary>

            IntPtr oHandle;
            public void OpenConnection(PictureBox pictureBox)
            {
                string DeviceIndex = Convert.ToString(DeviceID);
                oHandle = pictureBox.Handle;

                // Otwórz okno podglądu w PictureBox.
                // Utwórz okno potomne za pomocą capCreateCaptureWindowA, aby móc je wyświetlić w ramce graficznej.

                hHwnd = capCreateCaptureWindowA(ref DeviceIndex, WS_VISIBLE | WS_CHILD, 0, 0, 640, 480, oHandle.ToInt32(), 0);


                // Połącz się z urządzeniem
                if (SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, DeviceID, 0) != 0)
                {
                    // Ustaw skalę podglądu
                    SendMessage(hHwnd, WM_CAP_SET_SCALE, -1, 0);
                    // Ustaw częstotliwość podglądu w milisekundach
                    SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 50, 0);
                    // Rozpocznij podgląd obrazu z kamery
                    SendMessage(hHwnd, WM_CAP_SET_PREVIEW, -1, 0);
                    // Zmień rozmiar okna, aby zmieściło się w ramce graficznej
                    SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, pictureBox.Width, pictureBox.Height, SWP_NOMOVE | SWP_NOZORDER);
                    CameraIsActive = true;

                }
                else
                {
                    // Błąd połączenia z urządzeniem, zamknij okno
                    DestroyWindow(hHwnd);
                }
            }

            void CloseConnection()
            {
                SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, DeviceID, 0);
                // Zamknij okno
                DestroyWindow(hHwnd);
            }

            public Bitmap GetCurrentImage()
            {
                if (!CameraIsActive)
                {
                    Console.WriteLine("Kamera wyłączona");
                    return null;
                }
                // pobierz następną klatkę
                SendMessage(hHwnd, WM_CAP_GET_FRAME, 0, 0);

                // skopiuj ramkę do schowka
                SendMessage(hHwnd, WM_CAP_COPY, 0, 0);
                //Wznów podgląd
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, -1, 0);

                // Pobierz obraz ze schowka i przekonwertuj go na bitmapę
                IDataObject data = Clipboard.GetDataObject();
                if (data.GetDataPresent(typeof(Bitmap)))
                {
                    var oImage = (Bitmap)data.GetData(typeof(Bitmap));
                    return oImage;
                }

                return null;
            }

            public void StopPreview()
            {
                // Wyślij odpowiedni komunikat, aby zatrzymać podgląd
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, 0, 0);
                CloseConnection();

            }

            //Funkcja do Rozpoczęcia nagrywania - Nie działa
            public void StartRecording()
            {
                if (isRecording)
                {
                    Console.WriteLine("Nagrywanie już trwa.");
                    return;
                }
                SendMessage(hHwnd, WM_CAP_SEQUENCE, 0, 0);
                if (SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, 0, 0) != 0)
                {
                    SendMessage(hHwnd, WM_CAP_SEQUENCE, 0, 0);
                }

                isRecording = true;
            }

            // Funkcja do zakończenia nagrywania - Nie działa
            public void StopRecording(SaveFileDialog saveFileDialog)
            {
                if (!isRecording)
                {
                    Console.WriteLine("Nagrywanie nie jest w trakcie.");
                    return;
                }


                string path;

                saveFileDialog.Filter = "AVI Files (*.avi)|*.avi|All files (*.*)|*.*"; // Ustaw filtr plików
                saveFileDialog.Title = "Zapisz nagranie"; // Ustaw tytuł okna dialogowego

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = saveFileDialog.FileName;
                }
                else
                {
                    // Użytkownik anulował okno dialogowe
                    Console.WriteLine("Nagrywanie nie zostało zapisane.");
                    return;
                }



                try
                {
                    SendMessage(hHwnd, WM_CAP_FILE_SAVEAS, 0, path);
                    SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, 0, 0);
                    Console.WriteLine("Film Zapisany");

                }
                catch (Exception ex)
                {
                    // Handle exception
                    Console.WriteLine(path + ": " + ex.Message);
                }
            }

                

            private Bitmap previousFrame;
            Timer motionDetectionTimer;
            private int detectionLevel;
            private Label motionDetectionLabel;

            public void StartMotionDetection(int detectionLevel, Label motionDetectionLabel)
            {
                // Sprawdź, czy kamera jest aktywna
                if (!CameraIsActive)
                {
                    Console.WriteLine("Kamera nie jest aktywna.");
                    return;
                }

                // Inicjalizuj poprzednią klatkę
                previousFrame = GetCurrentImage();
                this.detectionLevel = detectionLevel;
                this.motionDetectionLabel = motionDetectionLabel;
                // Uruchom timer do cyklicznego sprawdzania detekcji ruchu
                motionDetectionTimer = new Timer();
                motionDetectionTimer.Interval = 1000; // Możesz dostosować interwał do potrzeb
                motionDetectionTimer.Tick += MotionDetectionTimer_Tick;
                motionDetectionTimer.Start();
            }
            public void StopMotionDetection()
            {
                motionDetectionTimer.Stop();
            }

            private void MotionDetectionTimer_Tick(object sender, EventArgs e)
            {
                // Pobierz bieżącą klatkę
                Bitmap currentFrame = GetCurrentImage();

                if (currentFrame != null && previousFrame != null)
                {
                    // Wykonaj detekcję ruchu
                    bool motionDetected = DetectMotion(previousFrame, currentFrame);

                    // Możesz dodać dodatkową logikę w zależności od tego, czy wykryto ruch
                    if (motionDetected)
                    {
                        //Console.WriteLine("Wykryto ruch!");
                        // Tutaj można podjąć odpowiednie działania w przypadku wykrycia ruchu
                        motionDetectionLabel.ForeColor = Color.Red;
                        motionDetectionLabel.Text = "!!!Wykryto ruch!!!";
                    }
                }

                // Zapisz bieżącą klatkę jako poprzednią do kolejnej iteracji
                previousFrame = currentFrame;
            }

            private bool DetectMotion(Bitmap previousFrame, Bitmap currentFrame)
            {
                int changedPixels = 0;
                int totalPixels = currentFrame.Width * currentFrame.Height;

                // Próg detekcji - ustaw na 5% zmiany jako przykład
                int detectionThreshold = (int)(totalPixels * detectionLevel / 100.0);

                // Iteracja po pikselach
                for (int x = 0; x < currentFrame.Width; x++)
                {
                    for (int y = 0; y < currentFrame.Height; y++)
                    {
                        Color previousPixel = previousFrame.GetPixel(x, y);
                        Color currentPixel = currentFrame.GetPixel(x, y);

                        // Porównanie pikseli
                        if (Math.Abs(previousPixel.R - currentPixel.R) > 10 ||
                            Math.Abs(previousPixel.G - currentPixel.G) > 10 ||
                            Math.Abs(previousPixel.B - currentPixel.B) > 10)
                        {
                            changedPixels++;
                        }
                    }
                }

                // Jeśli liczba zmienionych pikseli przekracza próg detekcji, uznaj to za ruch
                if (changedPixels >= detectionThreshold)
                {
                    return true; // Wykryto ruch
                }

                motionDetectionLabel.Text = "";
                return false; // Brak ruchu

            }

            ~WebCamControl()
            {
                Dispose(false);
                GC.SuppressFinalize(this);
            }

            public void Dispose()
            {
                Dispose(true);
            }

            virtual protected void Dispose(bool disposing)
            {
                CloseConnection();
            }

        }
    }
}
