using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчики на изменение текста внутри полей для ввода X и У
            number.TextChanged += Input_TextChanged;
        }

        private static int foo(int x) {
            if (x % 5 == 0) {
                return x / 5;
            } else {
                return x + 1;
            }
        }

        private void Input_TextChanged(object sender, EventArgs e) {
            try {
                output.Text = foo(Convert.ToInt32(number.Text)).ToString();
            } catch (Exception) {
                output.Text = "Неверные данные!";
            }
        }
    }
}
