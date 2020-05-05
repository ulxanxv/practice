using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            outputButton.Click += OutButton_Click;
        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {
            string[] context = File.ReadAllLines("file.txt");

            MatchCollection matches;
            for (int i = 0; i < context.Length; ++i) {
                matches = new Regex(@".*\s.*").Matches(context[i]);

                if (matches.Count > 0) {
                    output.Text += context[i] + "\r\n";
                }
            }
        }
    }
}
