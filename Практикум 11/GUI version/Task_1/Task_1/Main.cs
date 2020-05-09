using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        private DateWork date = new DateWork();

        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            resultButton.Click += OutButton_Click;
            setDateButton.Click += SetDate_Click;
        }

        private void SetDate_Click(object sender, EventArgs e) {
            setNewDate();
        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {
            output.Text = "";

            output.Text += "Вчерашняя дата — " + date.yesterdayDate() + "\n";
            output.Text += "Завтряшняя дата — " + date.tomorrowDate() + "\n";
            output.Text += string.Format("До конца месяца {0} суток", date.howEnd()) + "\n";
            output.Text += date.LeapYear ? "Год вискосный\n" : "Год не високосный\n";
            output.Text += "Дата — " + date.Date;
        }

        private void setNewDate() {
            try {
                date.Date = DateTime.Parse(setDate.Text);
                output.Text = "Новая дата была установлена!";
            } catch (Exception) {
                output.Text = "Дата была введена неверно — будет установлена дата 01.01.2009";
                date.Date = DateTime.Parse("01.01.2009");
            }
        }
    }
}
