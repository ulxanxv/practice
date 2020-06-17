using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Components {
    public partial class Twelfth : Form {
        public Twelfth() {
            InitializeComponent();
            this.Load += Twelfth_Load;
        }

        private void Twelfth_Load(object sender, EventArgs e) {
            GraphicsPath gp = new GraphicsPath();

            gp.AddEllipse(0, 0, 100, 100);
            gp.AddEllipse(110, 0, 100, 100);

            Region r        = new Region(gp);
            this.Region     = r;
        }
    }
}
