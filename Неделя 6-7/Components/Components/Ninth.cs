using System;
using System.Windows.Forms;

namespace Components {
    public partial class Ninth : Form {

        public Ninth() {
            InitializeComponent();

            cutButton.Click     += Button_Click;
            copyButton.Click    += Button_Click;
            pasteButton.Click   += Button_Click;

            button.Click += Button_Click1;
        }

        private void Button_Click1(object sender, EventArgs e) {
            ContextMenuStrip cms = new ContextMenuStrip();

            cms.Items.AddRange(new ToolStripItem[] {
                this.cutButton,
                this.copyButton,
                this.pasteButton
            });

            this.ContextMenuStrip = cms;
        }

        private void Button_Click(object sender, EventArgs e) {
            MessageBox.Show((sender as ToolStripMenuItem).Text + " is pressed!");
        }
    }
}
