using System;
using System.Windows.Forms;
using System.Linq;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчики на изменение текста внутри полей для ввода X и У
            inputBinary.TextChanged += InputBinary_TextChanged;
        }

        private void InputBinary_TextChanged(object sender, EventArgs e) {
            try {
                if (inputBinary.Text.Where(x => (x != '1' && x != '0')).Count() > 0) {
                    throw new FormatException();
                }

                convertToDecimal(inputBinary.Text);
            } catch (Exception) {
                output.Text = "Неверный формат данных!";
                return;
            }
        }

        private void convertToDecimal(string binary, int decimalNumber = 0) {
            if (binary.Length != 0) {
                decimalNumber += int.Parse(binary[0].ToString()) * (int)Math.Pow(2, binary.Length - 1);
                binary = binary.Substring(1, binary.Length - 1);

                convertToDecimal(binary, decimalNumber);
            } else {
                output.Text = "Десятичное число — " + decimalNumber;
            }
        }
    }
}
