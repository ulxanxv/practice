using System;
using System.Windows.Forms;

namespace Components {
    public partial class Second : Form {
        public Second() {
            InitializeComponent();

            divideButton.Click += DivideButton_Click;
        }

        private void DivideButton_Click(object sender, EventArgs e) {
            try {
                outputLabel.Text = "Ответ — " + Convert.ToInt32(firstNumber.Text) / Convert.ToInt32(secondNumber.Text);
            } catch (DivideByZeroException ex) {
                outputLabel.Text = "Ответ — " + ex.Message;
            } catch {
                outputLabel.Text = "Ответ — неизвестная ошибка!";
            }
        }
    }
}
