using System;
using System.Windows.Forms;

namespace Components {
    public partial class Third : Form {
        public Third() {
            InitializeComponent();

            divideButton.Click += DivideButton_Click;
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
