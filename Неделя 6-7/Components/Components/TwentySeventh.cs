using System;
using System.Drawing;
using System.Windows.Forms;

namespace Components {
    public partial class TwentySeventh : Form {

        private Color color;
        private int[] customColors = new int[] { 0xFF0000, 0xFFFF00, 0xFF00FF };

        public TwentySeventh() {
            InitializeComponent();

            this.justUsualButton.Click += JustUsualButton_Click;
        }

        private void JustUsualButton_Click(object sender, EventArgs e) {

            colorDialog.CustomColors = customColors;

            if (colorDialog.ShowDialog() == DialogResult.OK) {
                customColors = colorDialog.CustomColors;
                color = colorDialog.Color;
            }

        }
    }
}
