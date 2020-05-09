using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        private DateWork date1;
        private DateWork date2;

        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            resultButton.Click += OutButton_Click;

            setDateButton1.Click += SetDateButton1_Click;
            setDateButton2.Click += SetDateButton2_Click;
        }

        private void SetDateButton2_Click(object sender, EventArgs e) {
            try {
                date2 = (DateWork)setDate2.Text;
                output.Text = "Вторая дата установлена!";
            } catch (Exception) {
                output.Text = "Вторая дата не установлена! Неверные данные!";
                date2 = null;
            }
        }

        private void SetDateButton1_Click(object sender, EventArgs e) {
            try {
                date1 = (DateWork)setDate1.Text;
                output.Text = "Первая дата установлена!";
            } catch (Exception) {
                output.Text = "Первая дата не установлена! Неверные данные!";
                date1 = null;
            }
        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {
            output.Text = "Дата — ";
            output.Text += date1[Convert.ToInt32(days.Value)] + "\r\n";

            if (date1 == null || date2 == null) { output.Text = "Какая-то из дат не установлены!\r\n"; }

            if (date1 & date2) {
                output.Text += "Объекты равны\r\n";
            } else {
                output.Text += "Не равны\r\n";
            }

            if (date1) {
                output.Text += "Дата является началом года\r\n";
            } else {
                output.Text += "Дата не является началом года\r\n";
            }

            if (!date1) {
                output.Text += "Дата не является последним днем месяца\r\n";
            } else {
                output.Text += "Дата является последним днем месяца\r\n";
            }

            output.Text += "Приведение типа DateWork в тип string — " + (string)date1 + "\r\n";
        }

    }
}
