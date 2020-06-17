using System;
using System.IO;
using System.Windows.Forms;

namespace Components {
    public partial class Eighteenth : Form {
        public Eighteenth() {
            InitializeComponent();

            this.showButton.Click += ShowButton_Click;
            this.treeView.BeforeExpand += TreeView1_BeforeExpand;
        }

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e) {
            NodeExpand(e.Node);
        }

        private void ShowButton_Click(object sender, EventArgs e) {

            string[] drives = Directory.GetLogicalDrives();

            foreach (string s in drives) {
                TreeNode tn = treeView.Nodes.Add(s);
                tn.Nodes.Add("");
                tn.Tag = "";

            }

        }

        private void NodeExpand(TreeNode tn) {

            if (tn.Nodes.Count != 0) {

                if (((string)tn.Tag) == "") {
                    tn.Nodes.RemoveAt(0);
                    AddTreeNodes(tn);
                    tn.Tag = "+";
                }

            }

        }

        private String GetFullPath(TreeNode tn) {
            TreeNode currNode   = tn;
            String fullPath     = currNode.Text;

            while (currNode.Parent != null) {
                currNode = currNode.Parent;
                fullPath = currNode.Text + @"\" + fullPath;
            }

            return fullPath + @"\";
        }

        private void AddTreeNodes(TreeNode tn) {
            TreeNode aux;
            DirectoryInfo d = new DirectoryInfo(GetFullPath(tn));
            DirectoryInfo[] ds;

            try {
                ds = d.GetDirectories();

                foreach (DirectoryInfo s in ds) {
                    aux = tn.Nodes.Add(s.Name);
                    aux.Tag = "";

                    try {
                        if (s.GetDirectories().GetLength(0) != 0) {
                            aux.Nodes.Add("");
                        }
                    } catch (UnauthorizedAccessException) { }
                }
            } catch (Exception) {}
        }

    }
}
