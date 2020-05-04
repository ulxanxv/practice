using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчики на изменение текста внутри полей для ввода Дней и Даты
            days.TextChanged += Input_TextChanged;
            date.TextChanged += Input_TextChanged;
        }

        private void update() {
            DateTime    dateUser;
            int         amountDays;

            try {
                dateUser = DateTime.Parse(date.Text);
            } catch (FormatException) {
                output.Text = "Неверный формат данных!";
                return;
            } catch (ArgumentNullException) {
                output.Text = "Пустая строка!";
                return;
            }

            try {
                amountDays = Convert.ToInt32(days.Value);
            } catch (Exception) {
                output.Text = "Проверьте данные!";
                return;
            }

            output.Text = "Итоговая дата — " + dateUser.AddDays(amountDays).ToShortDateString();
        }

        private void Input_TextChanged(object sender, EventArgs e) {
            update();
        }
    }
}
