using System;
using System.Drawing;
using System.Windows.Forms;

namespace Components {
    public partial class Tenth : Form {
        public Tenth() {
            InitializeComponent();

            outputButton.Click += OutputButton_Click;
        }

        private void OutputButton_Click(object sender, EventArgs e) {
            Size sz     = SystemInformation.PrimaryMonitorSize;
            Font f      = SystemInformation.MenuFont;

            int k       = SystemInformation.MouseButtons,
                w       = SystemInformation.VerticalScrollBarWidth;

            String cn   = SystemInformation.ComputerName,
                   fn   = f.Name,
                   un   = SystemInformation.UserName;

            bool b      = SystemInformation.Network;

            outputText.Text = String.Format(
                "Размер окна — {0}" +
                "\nИспользуемый шрифт для меня и его имя — {1}, {2}" +
                "\nКоличество кнопок мыши — {3}" +
                "\nШирина вертикальной полосы прокрутки — {4}" +
                "\nПрисутствует ли сеть? — {5}" +
                "\nИмя текущего пользователя — {6}",
                sz, f, fn, k, w, b, cn
                );
        }
    }
}
