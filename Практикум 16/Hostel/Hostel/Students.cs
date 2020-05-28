using System;
using System.Windows.Forms;

namespace Hostel {
    public partial class Students : Form {
        public Students() {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.hostelDataSet.Students);

            updateButton.Click += UpdateButton_Click;
            exitButton.Click += ExitButton_Click;

        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            studentsTableAdapter.Update(hostelDataSet);
        }
    }
}
