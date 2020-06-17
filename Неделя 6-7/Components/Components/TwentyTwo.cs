using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Components {
    public partial class TwentyTwo : Form {
        public TwentyTwo() {
            InitializeComponent();

            this.Load += TwentyTwo_Load;
            this.linkLabel.LinkClicked += LinkLabel_LinkClicked;
        }

        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(e.Link.LinkData.ToString());
        }

        private void TwentyTwo_Load(object sender, EventArgs e) {
            linkLabel.Links[0].LinkData = "https://microsoft.com";
        }
    }
}
