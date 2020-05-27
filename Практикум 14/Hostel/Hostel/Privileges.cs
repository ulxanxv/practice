using System;
using System.Windows.Forms;

namespace Hostel {
    public partial class Privileges : Form {
        public Privileges() {
            InitializeComponent();
        }

        private void Privileges_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Privilege". При необходимости она может быть перемещена или удалена.
            this.privilegeTableAdapter.Fill(this.hostelDataSet.Privilege);

            updateButton.Click += UpdateButton_Click;
            exitButton.Click += ExitButton_Click;
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            privilegeTableAdapter.Update(hostelDataSet);
        }
    }
}
