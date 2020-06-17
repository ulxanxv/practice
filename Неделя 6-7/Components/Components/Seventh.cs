using System;
using System.Windows.Forms;
using System.Xml;

namespace Components {
    public partial class Seventh : Form {
        public Seventh() {
            InitializeComponent();

            viewButton.Click += ViewButton_Click;
        }


        private void ViewButton_Click(object sender, EventArgs e) {
            XmlDocument xml = new XmlDocument();
            xml.Load("example.xml");
            XmlNode d = xml.DocumentElement;
            XmlNodeList xnl = d.ChildNodes;

            for (int i = 0; i < d.ChildNodes.Count; i++) {
                MessageBox.Show(xnl[i].Attributes["text"].Value + " " + xnl[i].Attributes["rustext"].Value);
            }

        }
    }
}
