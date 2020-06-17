using System;
using System.Windows.Forms;

namespace Components {
    public partial class Fourteenth : Form {
        public Fourteenth() {
            InitializeComponent();

            this.addButton.Click += AddButton_Click;
            this.deleteButton.Click += DeleteButton_Click;
            this.deleteAllButton.Click += DeleteAllButton_Click;
            this.searchButton.Click += SearchButton_Click;

            this.Click += Fourteenth_Click;
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            treeView.SelectedNode = null;
            TreeNode tn = FindNode(treeView.Nodes, search.Text);

            if (tn != null) {
                treeView.SelectedNode = tn;
                treeView.Focus();
            }
        }

        private TreeNode FindNode(TreeNodeCollection tnc, string name) {

            foreach (TreeNode tn in tnc) {
                if (tn.Text == name) {
                    return tn;
                }
            }

            TreeNode node;
            foreach (TreeNode tn in tnc) {
                node = FindNode(tn.Nodes, name);

                if (node != null) {
                    return node;
                }
            }

            return null;
        }


        private void Fourteenth_Click(object sender, EventArgs e) {
            treeView.SelectedNode = null;
        }

        private void DeleteAllButton_Click(object sender, EventArgs e) {
            treeView.Nodes.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e) {
            TreeNode node = treeView.SelectedNode;
            if (node != null) {
                treeView.Nodes.Remove(node);
            } else {
                MessageBox.Show("Ничего не выделено");
            }
        }

        private void AddButton_Click(object sender, EventArgs e) {
            TreeNode node = treeView.SelectedNode;

            if (node == null) {
                treeView.Nodes.Add(nameNode.Text);
            } else {
                node.Nodes.Add(nameNode.Text);
            }

            nameNode.Text = "";
            nameNode.Focus();
        }
    }
}
