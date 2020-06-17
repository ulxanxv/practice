using System;
using System.Drawing;
using System.Windows.Forms;

namespace Components {
    public partial class TwentyNinth : Form {

        private Font userFont = DefaultFont;

        public TwentyNinth() {
            InitializeComponent();

            this.doButton.Click += DoButton_Click;
        }

        private void DoButton_Click(object sender, EventArgs e) {

            if (fontDialog.ShowDialog() == DialogResult.OK) {
                userFont = fontDialog.Font;
                Invalidate();
            }

        }

        protected override void OnPaint(PaintEventArgs e) {
            Graphics g = e.Graphics;

            g.DrawString("Test", userFont, Brushes.Blue, 300, 100);
            base.OnPaint(e);
        }

    }
}
