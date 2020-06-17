using System;
using System.Windows.Forms;

namespace Components {
    public partial class ThirtyFirst : Form {
        public ThirtyFirst() {
            InitializeComponent();

            saveFileButton.Click += SaveFileButton_Click;
        }

        private void SaveFileButton_Click(object sender, EventArgs e) {

            saveFileDialog.InitialDirectory = "C:\tmp";
            saveFileDialog.Filter = "abc files (*.abs)|*.abs|All files|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                string fileName = saveFileDialog.FileName;
            }

        }
    }
}
