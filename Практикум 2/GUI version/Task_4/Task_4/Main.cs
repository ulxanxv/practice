using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();
            Result();
        }

        private void Result() {
            for (int i = 1; i < 6; ++i) {
                for (int j = 1; j < i + 1; j++) {
                    output.Text += j + " ";
                } output.Text += "\r\n";
            }
        }
    }
}
