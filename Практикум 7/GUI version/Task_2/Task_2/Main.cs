using System;
using System.Windows.Forms;
using System.Linq;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            resultButton.Click += OutButton_Click;

        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {
            outputResult.Text = longWord();
        }

        private string longWord() {
            string[] allWords = new string (inputString.Text.Where(x => Char.IsLetter(x) && !Char.IsPunctuation(x) || x == ' ').ToArray()).Split(' ');

            int maxLength = 0, index = 0;
            for (int i = 0; i < allWords.Length; ++i) {
                if (allWords[i].Length > maxLength) {
                    maxLength = allWords[i].Length;
                    index = i;
                }
            }

            return allWords[index];
        }
    }
}
