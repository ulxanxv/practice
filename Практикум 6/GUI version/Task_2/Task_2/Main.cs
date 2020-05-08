using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            resultButton.Click += OutButton_Click;

            // Всплывающая подсказка о том, как вводить массив
            toolTip1.SetToolTip(this.inputArray, "Пример ввода массива — 1 4 2 5 6 3 2");
        }

        static int lastMinimal(int[] array) {
            int minimalNumber = array[0];

            for (int i = 0; i < array.Length; ++i) {
                if (array[i] < minimalNumber) { minimalNumber = array[i]; }
            }

            for (int i = array.Length - 1; i > -1; --i) {
                if (array[i] == minimalNumber) { return i; }
            }

            return 0;
        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {
            int[] array;

            array = getArray();

            if (array != null) {
                try {
                    outputResult.Text = "Позиция последнего минимального — " + lastMinimal(array);
                    print(array);
                } catch (Exception) {
                    outputResult.Text = "Неверный диапазон значений!";
                    return;
                }
            }
        }

        private void print(int[] array) {
            outputArray.Text = "Ваш массив:\n";
            for (int z = 0; z < array.Length; ++z) {
                outputArray.Text += array[z] + " ";
            }
        }

        private int[] getArray() {
            string[] infoArray  = inputArray.Text.Trim().Split(' ');
            int[] array         = new int[inputArray.Text.Trim().Split(' ').Length];

            try {
                for (int z = 0; z < array.Length; ++z) {
                    array[z] = int.Parse(infoArray[z]);
                }
            } catch (Exception) {
                outputResult.Text = "Неверные данные!";
                return null;
            }

            return array;
        }
    }
}
