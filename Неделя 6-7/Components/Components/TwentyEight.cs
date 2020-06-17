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
    public partial class TwentyEight : Form {

        private Color color;
        private String firstName;


        public TwentyEight() {
            InitializeComponent();

            this.firstChangeButton.Click += FirstChangeButton_Click;
            this.secondChangeButton.Click += SecondChangeButton_Click;
            this.Load += TwentyEight_Load;
            this.Paint += TwentyEight_Paint;
        }

        private void TwentyEight_Paint(object sender, PaintEventArgs e) {

            Graphics g  = e.Graphics;
            Font font   = new Font("Arial", 10);

            g.DrawString(firstName, font, new SolidBrush(color), 300, 100);

        }

        private void TwentyEight_Load(object sender, EventArgs e) {

            try {
                color       = Properties.Settings.Default.MyColor;
                firstName   = Properties.Settings.Default.FirstName;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        private void SecondChangeButton_Click(object sender, EventArgs e) {
            color       = Color.Firebrick;
            firstName   = "Roman";
            Invalidate();

            Properties.Settings.Default.MyColor     = Color.Firebrick;
            Properties.Settings.Default.FirstName   = firstName;

            Properties.Settings.Default.Save();

        }

        private void FirstChangeButton_Click(object sender, EventArgs e) {
            color       = Color.MediumPurple;
            firstName   = "Ivan";
            Invalidate();

            Properties.Settings.Default.MyColor     = color;
            Properties.Settings.Default.FirstName   = firstName;

            Properties.Settings.Default.Save();

        }
    }
}
