using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            resultButton.Click += OutButton_Click;

            // Всплывающая подсказка о том, как вводить массив
            toolTip1.SetToolTip(this.inputArray, "Пример ввода массива — \n1 4\n3 2 \n1 2");
        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private void result() {
            int[,] array;

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

        private int countNumbers(int[,] array, int a, int b) {
            int count = 0;

            for (int z = 0; z < array.GetLength(0); ++z) {
                for (int y = 0; y < array.GetLength(1); ++y) {
                    if (a <= array[z, y] && array[z, y] <= b) {
                        ++count;
                    }
                }
            }

            return count;
        }

        private void print(int[,] array) {
            for (int z = 0; z < array.GetLength(0); ++z) {
                for (int y = 0; y < array.GetLength(1); ++y) {
                    outputResult.Text += array[z, y] + " ";
                }
                outputResult.Text += "\n";
            }
        }

        private int[,] getArray() {
            string[] infoArray  = inputArray.Text.Trim().Split('\n');

            int rows            = inputArray.Text.Trim().Split('\n').Length;
            int columns         = inputArray.Text.Trim().Split('\n')[0].Split(' ').Length;

            int[,] array        = new int[rows, columns];

            string[] row;
            try {
                for (int z = 0; z < array.GetLength(0); ++z) {
                    row = infoArray[z].Split(' ');
                    for (int y = 0; y < array.GetLength(1); ++y) {
                        array[z, y] = int.Parse(row[y]);
                    }
                }
            } catch (Exception) {
                outputResult.Text = "Неверные данные!";
                return null;
            }

            return array;
        }
    }
}
