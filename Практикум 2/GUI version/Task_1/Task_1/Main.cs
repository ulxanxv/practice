using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчики на изменение текста внутри полей для ввода X и У
            inputX.TextChanged += Input_TextChanged;
            inputY.TextChanged += Input_TextChanged;
        }

        private void update() {
            int x, y;

            try {
                x = int.Parse(inputX.Text);
                y = int.Parse(inputY.Text);
            } catch (FormatException) {
                output.Text = "Неверный формат данных!";
                return;
            } catch (OverflowException) {
                output.Text = "Слишком большие числа!";
                return;
            }

            if ((x > -50 && x < 50) && (y < 25 && y > -25)) {
                output.Text = "Точка внутри заштрихованной области!";
            } else if ((x == -50 || x == 50) || (y == 25 || y == -25)) {
                output.Text = "Точка лежит на границе!";
            } else {
                output.Text = "Точка лежит вне заштрихованной области!";
            }
        }

        private void Input_TextChanged(object sender, EventArgs e) {
            update();
        }
    }
}
