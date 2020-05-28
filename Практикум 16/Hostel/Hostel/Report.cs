using System;
using System.Windows.Forms;

namespace Hostel {
    public partial class Report : Form {
        public Report() {
            InitializeComponent();

            exitButton.Click += ExitButton_Click;
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Report_Load(object sender, EventArgs e) {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "HostelDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.StudentsTableAdapter.Fill(this.HostelDataSet.Students);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}