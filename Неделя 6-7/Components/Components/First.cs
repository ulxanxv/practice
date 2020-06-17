using System;
using System.Windows.Forms;

namespace Components {
    public partial class First : Form {
        public First() {
            InitializeComponent();

            divideButton.Click += PlusButton_Click;
        }

        private void PlusButton_Click(object sender, EventArgs e) {
            outputLabel.Text = "Ответ — " + Convert.ToInt32(firstNumber.Text) / Convert.ToInt32(secondNumber.Text);
        }
    }
}
