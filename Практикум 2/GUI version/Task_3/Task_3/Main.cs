using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчики на изменение текста внутри полей для ввода A, B, X и Y
            inputA.TextChanged += Input_TextChanged;
            inputB.TextChanged += Input_TextChanged;
            inputX.TextChanged += Input_TextChanged;
            inputY.TextChanged += Input_TextChanged;
        }

        private void update() {
            int a, b, x, y;

            output.Text = "";

            try {
                a = int.Parse(inputA.Text);
                b = int.Parse(inputB.Text);

                x = int.Parse(inputX.Text);
                y = int.Parse(inputY.Text);

                if (b < a || x > 9 || y > 9) throw new Exception();
            } catch (Exception) {
                output.Text = "Неверные данные!";
                return;
            }

            // Цикл while
            output.Text += "Цикл while\r\n";
            int count = a - 1;
            while (++count <= b) {
                if (count % 10 == x || count % 10 == y) {
                    output.Text += count + " ";
                }
            }

            // Цикл do while
            output.Text += "Цикл do while\r\n";
            count = a;
            do {
                if (count % 10 == x || count % 10 == y) {
                    output.Text += count + " ";
                }
            } while (++count <= b);

            // Цикл for
            output.Text += "Цикл for\r\n";
            for (count = a; count <= b; ++count) {
                if (count % 10 == x || count % 10 == y) {
                    output.Text += count + " ";
                }
            }
        }

        private void Input_TextChanged(object sender, EventArgs e) {
            update();
        }
    }
}
