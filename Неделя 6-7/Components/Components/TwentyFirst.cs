using System;
using System.Windows.Forms;

namespace Components {
    public partial class TwentyFirst : Form {
        public TwentyFirst() {
            InitializeComponent();

            findClassButton.Click += FindClass_Click;
        }

        private void FindClass_Click(object sender, EventArgs e) {
            Type t              = Type.GetType("Components." + findTextBox.Text);
            ISomeInterface w    = (ISomeInterface) Activator.CreateInstance(t);

            w.someMethod();
        }
    }
}
