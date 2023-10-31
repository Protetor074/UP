using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Karta_dzwiekowa;
using SharpDX.XAudio2;
using SharpDX.Multimedia;
using System.IO;

namespace WindowsFormsApp13 {
    public partial class OknoGlowne : Form {


        private OpenFileDialog fileDialog; //obiekt listy plików
        NAudio.Wave.WaveOut waveOutDevice = new NAudio.Wave.WaveOut(); //obiekt urządzenia
        NAudio.Wave.WaveIn waveIn; //obiekt do nagrywania dźwięku
        NAudio.Wave.WaveFileWriter waveWriter; //obiekt do obsługi nagrywania
        NAudio.Wave.AudioFileReader audioFileReader; //obiekt do czytania z pliku
        Header header; //obiekt nagłówka
        
        //DS ds; //obiekt odtwarzania przez DirectSound

        public OknoGlowne() {
            InitializeComponent();

            InitializeComponent();
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
          
        }

        //import winmm.dll do PlaySound()
        [DllImport("winmm.DLL", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        private static extern bool PlaySound(string pszSound, System.IntPtr hmod, PlaySoundFlags flags);

        //flagi dla PlaySound()
        [System.Flags]
        public enum PlaySoundFlags : int {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }

        //wyświetlenie nagłówka pliku WAV
        private void button4_Click(object sender, EventArgs e) {
            header.ReadHeader(fileDialog.InitialDirectory + fileDialog.FileName,informacje);
        }

        //uruchomienie PlaySound()
        private void button5_Click(object sender, EventArgs e) {
            //ustawienie flagi na asynchroniczną
            PlaySound(fileDialog.InitialDirectory + fileDialog.FileName, new System.IntPtr(), PlaySoundFlags.SND_ASYNC);
            Console.WriteLine("dziala");
            button1.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
           
        }
        

        //przycisk wyboru pliku WAV z listy
        private void button1_Click(object sender, EventArgs e) {
            fileDialog = new OpenFileDialog(); //utworzenie okna wyboru pliku
            fileDialog.Filter = @"Wave FIle (*.wav)|*.wav;"; //filtrowanie plików na .wav
            fileDialog.ShowDialog(); //pokazanie okna
            string fileName = System.IO.Path.GetFileName(fileDialog.FileName); //odczytywanie nazwy pliku z ścieżki
            this.header = new Header(fileDialog.InitialDirectory + fileDialog.FileName); //odczytanie nagłówka pliku
            if (fileName != "")  //pokazanie nazwy pliku WAV na przycisku
                button1.Text = fileName;
            else
                button1.Text = "Wczytaj plik *.wav";
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        
        }

        //wyłączenie PlaySound()
        private void button2_Click(object sender, EventArgs e) {
            PlaySound(null, (IntPtr)null, PlaySoundFlags.SND_ASYNC); //ustawienie ścieżki na NULL
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
           
            button1.Enabled = true;
            
        }


     

        //uruchomienie nagrywania dźwięku
        private void button8_Click(object sender, EventArgs e) {
            waveIn = new NAudio.Wave.WaveIn();
            waveIn.WaveFormat = new NAudio.Wave.WaveFormat(44100, 1); //ustawienie formatu pliku
            waveIn.DataAvailable += new EventHandler<NAudio.Wave.WaveInEventArgs>(waveIn_safeRecord);
            string path = "test2.wav"; //ustawienie nazwy pliku
            Console.WriteLine("nagranie rozpoczete");
            waveWriter = new NAudio.Wave.WaveFileWriter(path, waveIn.WaveFormat); //zapisywanie danych do pliku

            waveIn.StartRecording(); //rozpoczęcie nagrywania
            button1.Enabled = false;
            button4.Enabled = false;
     
            button6.Enabled = false;
            button7.Enabled = false;
           
            button2.Enabled = false;
            button5.Enabled = false;
        }

        //zatrzymanie nagrywania
        private void button9_Click(object sender, EventArgs e) {
            waveIn.StopRecording();

            waveIn.Dispose();
            waveWriter.Dispose();
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
         
            button1.Enabled = true;
        
        }

        //obsługa zdarzenia nagrywania
        private void waveIn_safeRecord(object sender, NAudio.Wave.WaveInEventArgs e) {
            if (waveWriter != null) {
                waveWriter.Write(e.Buffer, 0, e.BytesRecorded);
                waveWriter.Flush();
            }
        }


        //odtworzenie dżwięku z WaveOut()
        private void button6_Click(object sender, EventArgs e) {
            audioFileReader = new NAudio.Wave.AudioFileReader(fileDialog.FileName);
            waveOutDevice.Init(audioFileReader); //przekazanie pliku WAV do inicjacji

            waveOutDevice.Play(); //odtworzenie dźwięku
            button1.Enabled = false;
            button4.Enabled = false;
       
            button8.Enabled = false;
            button9.Enabled = false;
          
            button2.Enabled = false;
            button5.Enabled = false;
        }

        //zatrzymanie odtwarzania WaveOut()
        private void button7_Click(object sender, EventArgs e) {
            waveOutDevice.Stop();
            audioFileReader.Close(); //zamknięcie strumienia danych
            button2.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
     
            button1.Enabled = true;
            
        }

        SourceVoice sourceVoice;
        private void PlayDirectS_Click(object sender, EventArgs e) {
            try
            {
                // Inicjalizacja XAudio2
                using (var xaudio = new XAudio2())
                {
                    // Tworzenie głównego głosu
                    var masteringVoice = new MasteringVoice(xaudio);

                    // Wczytanie pliku dźwiękowego jako strumień
                    using (var fileStream = File.OpenRead(fileDialog.FileName))
                    {
                        // Tworzenie głosu dla dźwięku
                        var soundStream = new SoundStream(fileStream);
                        var waveFormat = soundStream.Format;
                        var buffer = new AudioBuffer
                        {
                            Stream = soundStream.ToDataStream(),
                            AudioBytes = (int)soundStream.Length,
                            Flags = BufferFlags.EndOfStream
                        };

                        // Tworzenie głosu dla dźwięku
                        sourceVoice = new SourceVoice(xaudio, waveFormat, true);
                        sourceVoice.SubmitSourceBuffer(buffer, soundStream.DecodedPacketsInfo);
                        soundStream.Dispose();

                        // Odtwarzanie dźwięku
                        sourceVoice.Start();

                     
                        
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }


        }

        private void StopDirectS_Click(object sender, EventArgs e)
        {
            // Zatrzymywanie odtwarzania i zwolnienie zasobów
            sourceVoice.Stop();
            sourceVoice.Dispose();
        }
    }
}
