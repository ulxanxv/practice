using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Hostel {
    public partial class RequestForm : Form {
        public RequestForm() {
            InitializeComponent();

            runRequestButton.Click += RunRequestButton_Click;
            clearButton.Click += ClearButton_Click;
        }

        private void ClearButton_Click(object sender, EventArgs e) {
            int count = response.Columns.Count;
            for (int i = 0; i < count; ++i) {
                response.Columns.RemoveAt(0);
            }
        }

        private void RunRequestButton_Click(object sender, EventArgs e) {
            // НУЖНО УКАЗАТЬ СВОЙ ПУТЬ!!! У ВАС ОН ОТЛИЧАЕТСЯ!!!
            string path = @"C:\Users\Артём\Desktop\ПРАКТИКА\Выполненные задания\Практикум 15\Hostel.mdb";

            OleDbConnection dbConnection = new OleDbConnection(
                @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + path + ";"
            );

            dbConnection.Open();

            string str = "";

            if (fullInfo.Checked) {
                str = "SELECT * FROM Students";
            } if (shortInfo.Checked) {
                str = "SELECT SNP, Group, Address FROM Students";
            } if (groupList.Checked) {
                str = "SELECT DISTINCT Group FROM Students";
            } if (roomsIn3Floor.Checked) {
                str = "SELECT * FROM Rooms WHERE Floor=3";
            } if (studentListInGroupPO.Checked) {
                str = "SELECT * FROM Students WHERE Students.Group like 'ПО%'";
            }

            OleDbDataAdapter dataAdapter    = new OleDbDataAdapter(str, dbConnection);
            DataTable data                  = new DataTable();

            dataAdapter.Fill(data);
            response.DataSource = data;
            dbConnection.Close();
        }
    }
}