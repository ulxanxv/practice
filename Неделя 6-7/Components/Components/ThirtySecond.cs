using System;
using System.Windows.Forms;

namespace Components {
    public partial class ThirtySecond : Form {
        public ThirtySecond() {
            InitializeComponent();

            this.clickButton.Click += ClickButton_Click;
            this.Load += ThirtySecond_Load;
        }

        private void ThirtySecond_Load(object sender, EventArgs e) {
            clickButton.PerformClick();
        }

        private void ClickButton_Click(object sender, EventArgs e) {
            MessageBox.Show("Button pressed!");
        }
    }
}
