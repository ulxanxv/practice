using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчики события при изменении текста
            inputX1.TextChanged += Input_TextChanged;
            inputX2.TextChanged += Input_TextChanged;

            inputY1.TextChanged += Input_TextChanged;
            inputY2.TextChanged += Input_TextChanged;

            inputZ1.TextChanged += Input_TextChanged;
            inputZ2.TextChanged += Input_TextChanged;
        }

        private void update() {
            double  x1, x2,
                    y1, y2,
                    z1, z2;

            try {

                x1 = double.Parse(inputX1.Text);
                x2 = double.Parse(inputX2.Text);

                y1 = double.Parse(inputY1.Text);
                y2 = double.Parse(inputY2.Text);

                z1 = double.Parse(inputZ1.Text);
                z2 = double.Parse(inputZ2.Text);

            } catch (FormatException) {

                output.Text = "Некорректные данные :(";
                return;

            } catch (OverflowException) {

                output.Text = "Слишком большие числа!";
                return;

            }
            

            double peremeter =  Math.Sqrt(Math.Pow(y1 - x1, 2) + Math.Pow(y2 - x2, 2)) +
                                Math.Sqrt(Math.Pow(z1 - y1, 2) + Math.Pow(z2 - y2, 2)) +
                                Math.Sqrt(Math.Pow(x1 - z1, 2) + Math.Pow(x2 - z2, 2));

            output.Text = "Периметр равен — " + peremeter;
        }

        private void Input_TextChanged(object sender, EventArgs e) {
            update();
        }
    }
}
