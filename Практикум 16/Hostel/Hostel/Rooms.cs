using System;
using System.Windows.Forms;

namespace Hostel {
    public partial class Rooms : Form {

        public Rooms() {
            InitializeComponent();
        }

        private void RoomsMain_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.hostelDataSet.Rooms);

            updateButton.Click += UpdateButton_Click;
            exitButton.Click += ExitButton_Click;
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void UpdateButton_Click(object sender, EventArgs e) {
            roomsTableAdapter.Update(hostelDataSet);
        }

    }
}
