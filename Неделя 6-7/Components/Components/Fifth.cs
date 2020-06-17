using System;
using System.Drawing;
using System.Windows.Forms;

namespace Components {
    public partial class Fifth : Form {
        public Fifth() {
            InitializeComponent();

            divideButton.Click += DivideButton_Click;
            statusStrip.MouseClick += StatusStrip_MouseClick;
            statusStrip.Resize += StatusStrip_Resize;
            secondStatus.Paint += SecondStatus_Paint;
        }

        private void SecondStatus_Paint(object sender, PaintEventArgs e) {
            e.Graphics.DrawEllipse(new Pen(Color.Blue, width: 2), 2, 2, 15, 15);
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
