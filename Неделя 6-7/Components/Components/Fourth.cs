using System;
using System.Windows.Forms;

namespace Components {
    public partial class Fourth : Form {
        public Fourth() {
            InitializeComponent();

            this.divideButton.Click += DivideButton_Click;
            this.statusStrip.MouseClick += StatusStrip_MouseClick;
            this.statusStrip.Resize += StatusStrip_Resize;
        }

        private void StatusStrip_Resize(object sender, EventArgs e) {
            statusStrip.Items[0].Width = statusStrip.Width - 200;
        }

        private void StatusStrip_MouseClick(object sender, MouseEventArgs e) {
            MessageBox.Show("Clicked status bar!");
        }

        private void DivideButton_Click(object sender, EventArgs e) {
            try {
                outputLabel.Text = "Ответ — " + Convert.ToInt32(firstNumber.Text) / Convert.ToInt32(secondNumber.Text);
            } catch (DivideByZeroException ex) {
                firstStatus.Text = ex.Message;
            } catch {
                secondStatus.Text = "Неизвестная ошибка!";
            }
        }
    }
}
