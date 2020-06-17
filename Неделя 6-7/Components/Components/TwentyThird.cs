using System;
using System.Drawing;
using System.Windows.Forms;

namespace Components {
    public partial class TwentyThird : Form {
        public TwentyThird() {
            InitializeComponent();

            this.Load += TwentyThird_Load;
        }

        private void TwentyThird_Load(object sender, EventArgs e) {

            foreach (Control c in Controls) {
                c.ContextMenuStrip = contextMenuStrip;
                c.MouseDown += new MouseEventHandler(this.ShowPopupMenu);
            }

        }

        private void ShowPopupMenu(object sender, MouseEventArgs e) {

            if (e.Button == MouseButtons.Right) {
                Control c = (Control)sender;

                if (c.ContextMenuStrip != null) {
                    c.ContextMenuStrip.Show(c, new Point(e.X, e.Y));
                }

            }

        }

    }
}
