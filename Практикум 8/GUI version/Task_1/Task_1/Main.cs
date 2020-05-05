using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик события на кнопку
            changeButton.Click += OutButton_Click;
        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        /// <summary>
        /// Пример ввода — 54 (integer); 43,24 (decimal); 1,43*10^4 (exponential)
        /// </summary>
        private void result() {
            double summa = 0.0;

            string message = input.Text;

            // Маска для целых/дробных чисел
            MatchCollection matchesDecimal = new Regex(@"\d+\,?\d*").Matches(message);

            // Маска для чисел в экспоненциальной форме
            MatchCollection matchesExponential = new Regex(@"(\d+\,?\d+)\*10\^(\d+)").Matches(message);

            foreach (Match match in matchesDecimal) {
                try {
                    summa += double.Parse(match.Value);
                } catch { }
            }

            foreach (Group group in matchesExponential) {
                summa += double.Parse(group.Value.Split('*')[0]) * Math.Pow(10, double.Parse(group.Value.Split('^')[1]));
            }

            resultText.Text = summa.ToString();
        }
    }
}
