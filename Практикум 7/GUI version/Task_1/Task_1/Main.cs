using System;
using System.Text;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            changeButton.Click += OutButton_Click;

        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {
            outputString.Text = changeString().ToString();
        }

        private StringBuilder changeString() {
            StringBuilder str = new StringBuilder(inputString.Text);
            string substring1 = replaceString.Text;
            string substring2 = newString.Text;

            int countEntries = 0;
            for (int i = 0; i < str.Length; ++i) {
                if (str[i] == substring1[0]) {
                    for (int j = i, k = 0; j < str.Length && k < substring1.Length; ++j, ++k) {
                        if (str[j] == substring1[k]) {
                            countEntries++;
                        } else {
                            break;
                        }
                    }

                    if (countEntries == substring1.Length) {
                        str.Remove(i, substring1.Length);
                        str.Insert(i, substring2);
                    }

                    countEntries = 0;
                }
            }

            return str;
        }
    }
}
