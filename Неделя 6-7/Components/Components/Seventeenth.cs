using System;
using System.Windows.Forms;

namespace Components {
    public partial class Seventeenth : Form {
        public Seventeenth() {
            InitializeComponent();

            this.Load += Seventeenth_Load;
        }

        private void Seventeenth_Load(object sender, EventArgs e) {
            foreach (Control c in Controls) {
                if (c is ButtonBase) {
                    ((ButtonBase)c).FlatStyle = FlatStyle.System;
                }
            }
        }

    }
}
