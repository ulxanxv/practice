using System;
using System.Windows.Forms;

namespace Components {
    public partial class Eighth : Form {

        private int number = 0;

        public Eighth() {
            InitializeComponent();

            pressButton.Click += PressButton_Click;
        }

        private void PressButton_Click(object sender, EventArgs e) {
            ToolStripMenuItem mi    = new ToolStripMenuItem((number++).ToString());
            mi.Click                += this.ToolStripMenuItem_Click;

            menuItem.DropDownItems.Add(mi);
        }

        private void ToolStripMenuItem_Click(object sender, System.EventArgs e) {
            string s = ((ToolStripMenuItem)sender).Text;
            MessageBox.Show(s);
        }

    }
}
