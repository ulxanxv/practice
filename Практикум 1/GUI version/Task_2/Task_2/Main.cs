using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_2 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            input.TextChanged += Input_TextChanged;
        }

        private void outputResult() {
            int number;

            try {
                number = int.Parse(input.Text);
            } catch (FormatException) {
                output.Text = "Вы ввели не число :(";
                return;
            } catch (OverflowException) {
                output.Text = "Число уже превышает int! Может пора остановиться?";
                return;
            }

            if (number < 10 || number > 100) {
                output.Text = "Число не удовлетворяет заданию ;(";
            } else {
                if (((number / 10) + (number % 10)) % 3 == 0) {
                    output.Text = "Сумма цифр кратка трём :)";
                } else {
                    output.Text = "Сумма цифр не кратка трём ;(";
                }
            }
        }

        private void Input_TextChanged(object sender, EventArgs e) {
            outputResult();
        }
    }
}
