using System;
using System.IO;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            outputButton.Click += OutButton_Click;
        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {

            output.Text = "";

            if (File.Exists("file.dat")) { File.WriteAllText("file.dat", ""); }

            FileStream file             = new FileStream("file.dat", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter   = new BinaryWriter(file);
            BinaryReader binaryReader;

            int size;

            try {
                size = int.Parse(sizeTB.Text);

                // Числа заполняются рандомные
                Random random = new Random();
                for (int i = 0; i < size; ++i) {
                    binaryWriter.Write(random.NextDouble() * 1000);
                }
                
                binaryWriter.Close();

                file                = new FileStream("file.dat", FileMode.Open);
                binaryReader        = new BinaryReader(file);
                long byteInStream   = file.Length;

                double number, maxNumber;

                try {
                    maxNumber = double.Parse(maxNumberTB.Text);
                } catch (Exception) {
                    output.Text = "Неверный формат данных!";
                    return;
                }

                for (long i = 0; i < byteInStream; i += 16) {
                    file.Seek(i, SeekOrigin.Begin);

                    number = binaryReader.ReadDouble();

                    if (number < maxNumber) {
                        output.Text += string.Format("{0:f2} ", number);
                    }
                }

                binaryReader.Close();
                file.Close();

            } catch (Exception) {
                output.Text = "Неверный формат данных!";
                return;
            }
        }
    }
}
