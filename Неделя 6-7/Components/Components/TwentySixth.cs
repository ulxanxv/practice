using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components {
    public partial class TwentySixth : Form {
        public TwentySixth() {
            InitializeComponent();

            openButton.Click += OpenButton_Click;
        }

        private void OpenButton_Click(object sender, EventArgs e) {
            TwentySixth_2 f = new TwentySixth_2();

            if (f.ShowDialog() == DialogResult.OK) {
                dataTextBox.Text = f.dataTextBox.Text;
            }

        }
    }
}
