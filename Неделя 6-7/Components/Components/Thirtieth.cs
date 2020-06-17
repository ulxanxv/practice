using System;
using System.Windows.Forms;

namespace Components {
    public partial class Thirtieth : Form {

        private String fileName;

        public Thirtieth() {
            InitializeComponent();

            this.openButton.Click       += OpenButton_Click;
            this.multiOpenButton.Click  += MultiOpenButton_Click;
        }

        private void MultiOpenButton_Click(object sender, EventArgs e) {

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                outFileNames();
            }

        }

        private void OpenButton_Click(object sender, EventArgs e) {

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                fileName = openFileDialog.FileName;
                this.Text = fileName;
            }

            outFileNames();
        }

        private void outFileNames() {
            foreach (string s in openFileDialog.FileNames) {
                allFiles.Items.Add(s);
            }
        }

    }
}
