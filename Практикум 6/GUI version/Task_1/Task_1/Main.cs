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

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {
            int[] array;

            array = getArray();

            if (array != null) {
                try {
                    int a = int.Parse(inputA.Text),
                        b = int.Parse(inputB.Text);

                    print(array);

                    outputResult.Text = "Чисел — " + countNumbers(array, a , b);
                } catch (Exception) {
                    outputResult.Text = "Неверный диапазон значений!";
                    return;
                }
            }
        }

        private int countNumbers(int[] array, int a, int b) {
            int count = 0;

            for (int z = 0; z < array.Length; ++z) {
                if (a <= array[z] && array[z] <= b) {
                    ++count;
                }
            }

            return count;
        }

        private void print(int[] array) {
            outputArray.Text = "Ваш массив :\n";
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
