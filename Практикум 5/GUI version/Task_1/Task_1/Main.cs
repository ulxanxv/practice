using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик события на кнопку
            outButton.Click += OutButton_Click;
        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {
            int a, b, h;

            try {
                a = int.Parse(inputA.Text);
                b = int.Parse(inputB.Text);
                h = int.Parse(inputH.Text);

                for (double i = a; i <= b; i += h) {
                    try {
                        output.Text += string.Format("Значении функции в значении x = {0} — {1:f4}\r\n", i, foo(i));
                    } catch (FormatException) {
                        output.Text += "Функция не опредлена в значении x = " + i + "\r\n";
                    }
                }
            } catch (Exception) {
                output.Text = "Неверный формат данных!";
            }
        }

        private double foo(double x) {
            if (x == 2 || x - 2 < 0) {
                throw new FormatException();
            } else {
                return Math.Abs(Math.Log10(x - 2));
            }
        }
    }
}
