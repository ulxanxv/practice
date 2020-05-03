using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            outButton.Click += OutButton_Click;
        }

        private void OutButton_Click(object sender, EventArgs e) {
            outResult();
        }

        private void outResult() {
            double a, b, h;

            try {
                a = double.Parse(inputA.Text);
                b = double.Parse(inputB.Text);
                h = double.Parse(inputH.Text);
            } catch (Exception) {
                output.Text = "Неверный формат данных!";
                return;
            }

            double y;
            for (double i = a; i <= b; i += h) {
                foo(i, out y);
                output.Text += string.Format("f({0:f2}) = {1:f4}\r\n", i, y);
            }
        }

        private static double foo(double x) {
            if (x + 2 <= 1) {
                return x * x;
            } else if (1 < (x + 2) && (x + 2) < 10) {
                return 1 / (x + 2);
            } else {
                return x + 2;
            }
        }

        private static void foo(double x, out double y) {
            if (x + 2 <= 1) {
                y = x * x;
            } else if (1 < (x + 2) && (x + 2) < 10) {
                y = 1 / (x + 2);
            } else {
                y = x + 2;
            }
        }
    }
}
