using System;
using System.Drawing;
using System.Windows.Forms;

namespace Components {
    public partial class Thirteenth : Form {

        public Thirteenth() {
            InitializeComponent();

            this.Load                       += Thirteenth_Load;
            this.fonts.SelectedIndexChanged += Fonts_SelectedIndexChanged;
        }

        private void Fonts_SelectedIndexChanged(object sender, EventArgs e) {
            testLabel.Font = new Font(fonts.Text, 20);
        }

        private void Thirteenth_Load(object sender, EventArgs e) {
            foreach (FontFamily ff in new System.Drawing.Text.InstalledFontCollection().Families) {
                fonts.Items.Add(ff.Name);
            }
        }
    }
}
