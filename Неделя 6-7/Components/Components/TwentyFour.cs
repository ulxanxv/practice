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
    public partial class TwentyFour : Form {
        public TwentyFour() {
            InitializeComponent();

            this.Load                   += TwentyFour_Load;
            this.treeView.AfterCheck    += TreeView_AfterCheck;
        }

        private void TreeView_AfterCheck(object sender, TreeViewEventArgs e) {
            SelectAllSubnodes(e.Node);
        }

        void SelectAllSubnodes(TreeNode treeNode) {

            foreach (TreeNode treeSubNode in treeNode.Nodes) {
                treeSubNode.Checked = treeNode.Checked;
            }

        }


        private void TwentyFour_Load(object sender, EventArgs e) {
            TreeNode treeNode = treeView.Nodes.Add("Item1");
            TreeNode treeNode11 = treeNode.Nodes.Add("Item11");
            TreeNode treeNode12 = treeNode.Nodes.Add("Item12");

            treeNode11.Nodes.Add("Item111");
            treeNode11.Nodes.Add("Item112");
            treeNode12.Nodes.Add("Item121");
            treeNode12.Nodes.Add("Item122");

            treeNode.ExpandAll();

        }
    }
}
