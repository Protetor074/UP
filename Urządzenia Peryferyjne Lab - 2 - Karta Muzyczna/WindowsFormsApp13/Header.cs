using System;
using System.IO;

namespace Karta_dzwiekowa {
    //Klasa odpowiadająca za odczytanie i wyświetlanie nagłówka
    class Header {
        short formattype; //typ formatu
        short channels; //liczba kanałów
        int samplespersec; //częstotliwość próbkowania
        short bytespersample; //bajty na próbkę
        short bitespersample; //bity na próbkę
        public Header(String sciezka) {
            //użycie FileStream oraz BinaryReader do odczytu wartości z nagłówka
            using (var fileStream = new FileStream(sciezka, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(fileStream)) {
                try {
                    convertBinary(binaryReader.ReadBytes(4));
                    BitConverter.ToInt32(binaryReader.ReadBytes(4), 0);
                    convertBinary(binaryReader.ReadBytes(4));
                    convertBinary(binaryReader.ReadBytes(4));
                    BitConverter.ToInt32(binaryReader.ReadBytes(4), 0);
                    formattype = BitConverter.ToInt16(binaryReader.ReadBytes(2), 0);
                    channels = BitConverter.ToInt16(binaryReader.ReadBytes(2), 0);
                    samplespersec = BitConverter.ToInt32(binaryReader.ReadBytes(4), 0);
                    BitConverter.ToInt32(binaryReader.ReadBytes(4), 0);
                    bytespersample = BitConverter.ToInt16(binaryReader.ReadBytes(2), 0);
                    bitespersample = BitConverter.ToInt16(binaryReader.ReadBytes(2), 0);
                    BitConverter.ToInt32(binaryReader.ReadBytes(4), 0);
                    BitConverter.ToInt32(binaryReader.ReadBytes(4), 0);
                } finally {
                    binaryReader.Close(); //zamknięcie binaryReader
                    fileStream.Close(); //zamknięcie strumienia danych
                }

            }
        }
        //konwersja na łańcuch znakowy
        private string convertBinary(Byte[] bytes) {
            String word = "";
            foreach (var item in bytes) {
                word += (char)item;
            }

            return word;
        }

        public short getFormat() {
            return formattype;
        }
        public short getChannels() {
            return channels;
        }
        public int getSamplespersec() {
            return samplespersec;
        }
        public short getBytespersample() {
            return bytespersample;
        }
        public short getBitespersample() {
            return bitespersample;
        }

        //wyświetlenie nagłówka w konsoli
        public void ReadHeader(string sciezka, System.Windows.Forms.Label informacje) {
            using (var fileStream = new FileStream(sciezka, FileMode.Open, FileAccess.Read))
            using (var binaryReader = new BinaryReader(fileStream)) {
                try {
                    Console.WriteLine("RIFF: " + convertBinary(binaryReader.ReadBytes(4)));
                    informacje.Text = "RIFF: " + convertBinary(binaryReader.ReadBytes(4))+"\n";

                    Console.WriteLine("SIZE: " + BitConverter.ToInt32(binaryReader.ReadBytes(4), 0));
                    informacje.Text = informacje.Text + "SIZE: " + BitConverter.ToInt32(binaryReader.ReadBytes(4), 0) + "\n"; 
                    
                    Console.WriteLine("WAVE: " + convertBinary(binaryReader.ReadBytes(4)));
                    informacje.Text = informacje.Text + "fmt: " + convertBinary(binaryReader.ReadBytes(4)) + "\n";

                    Console.WriteLine("fmt: " + convertBinary(binaryReader.ReadBytes(4)));
                    informacje.Text = informacje.Text + "fmt: " + convertBinary(binaryReader.ReadBytes(4))  +"\n";

                    Console.WriteLine("Rozmiar formatu: " + BitConverter.ToInt32(binaryReader.ReadBytes(4), 0));
                    informacje.Text = informacje.Text + "Rozmiar formatu: " + BitConverter.ToInt32(binaryReader.ReadBytes(4), 0) + "\n";

                    formattype = BitConverter.ToInt16(binaryReader.ReadBytes(2), 0);
                    Console.WriteLine("Typ formatu: " + formattype);
                    informacje.Text = informacje.Text + "Typ formatu: " + formattype + "\n";

                    channels = BitConverter.ToInt16(binaryReader.ReadBytes(2), 0);
                    Console.WriteLine("Liczba kanałów: " + channels);
                    informacje.Text = informacje.Text + "Liczba kanałów: " + channels + "\n";


                    samplespersec = BitConverter.ToInt32(binaryReader.ReadBytes(4), 0);
                    Console.WriteLine("SampleRate: " + samplespersec);
                    informacje.Text = informacje.Text + "SampleRate: " + samplespersec + "\n";


                    Console.WriteLine("BytesPerSecound " + BitConverter.ToInt32(binaryReader.ReadBytes(4), 0));
                    informacje.Text = informacje.Text + "BytesPerSecound " + BitConverter.ToInt32(binaryReader.ReadBytes(4), 0) + "\n";

                    bytespersample = BitConverter.ToInt16(binaryReader.ReadBytes(2), 0);
                    Console.WriteLine("BytesPerSample: " + bytespersample);
                    informacje.Text = informacje.Text + "BytesPerSample: " + bytespersample + "\n";

                    bitespersample = BitConverter.ToInt16(binaryReader.ReadBytes(2), 0);
                    Console.WriteLine("BitsPerSample: " + bitespersample);
                    informacje.Text = informacje.Text + "BitsPerSample: " + bitespersample + "\n";

                    Console.WriteLine("Data: " + convertBinary(binaryReader.ReadBytes(4)));
                    informacje.Text = informacje.Text + "Data: " + convertBinary(binaryReader.ReadBytes(4)) + "\n";

                    Console.WriteLine("DataSize: " + BitConverter.ToInt32((binaryReader.ReadBytes(4)), 0));
                    informacje.Text = informacje.Text + "DataSize: " + BitConverter.ToInt32((binaryReader.ReadBytes(4)), 0) + "\n";

                } finally {
                    binaryReader.Close();
                    fileStream.Close();
                }

            }
        }


    }

}
