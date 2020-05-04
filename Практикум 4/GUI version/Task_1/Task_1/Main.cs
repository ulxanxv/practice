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
            try {
                output.Text = chainFraction(int.Parse(inputX.Text), int.Parse(inputN.Text)).ToString();
            } catch (Exception) {
                output.Text = "Неверный формат данных!";
                return;
            }
        }

        static double chainFraction(int x, int n, int count = 0) {
            if (count < n) {
                return x / chainFraction(x, n, count + 1);
            } else {
                return x + n;
            }
        }
    }
}
