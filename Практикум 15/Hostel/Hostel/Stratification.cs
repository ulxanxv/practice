using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel {
    public partial class Stratification : Form {
        public Stratification() {
            InitializeComponent();

            exitButton.Click += ExitButton_Click;
            confirmChanges.Click += ConfirmChanges_Click;
        }

        private void ConfirmChanges_Click(object sender, EventArgs e) {
            roomsBindingSource.EndEdit();
            roomsTableAdapter.Update(hostelDataSet);
            studentsTableAdapter.Update(hostelDataSet);
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void roomsBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.roomsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hostelDataSet);

        }

        private void Stratification_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.hostelDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "hostelDataSet.Rooms". При необходимости она может быть перемещена или удалена.
            this.roomsTableAdapter.Fill(this.hostelDataSet.Rooms);

        }
    }
}
