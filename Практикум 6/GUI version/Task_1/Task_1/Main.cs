using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            resultButton1D.Click += ResultButton1D_Click;
            resultButton2D.Click += ResultButton2D_Click;

            // Всплывающая подсказка о том, как вводить массив
            toolTip1.SetToolTip(this.input1DArray, "Пример ввода массива:\n1 4 2 5 6 3 2");
            toolTip1.SetToolTip(this.input2DArray, "Пример ввода массива:\n1 4 2\n5 6 3\n2 5 1");
        }

        private void ResultButton2D_Click(object sender, EventArgs e) {
            result2D();
        }

        private void ResultButton1D_Click(object sender, EventArgs e) {
            result1D();
        }

        private void result1D() {
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

        private void result2D() {
            int[,] array;

            getArray(out array);

            if (array != null) {
                try {
                    int a = int.Parse(inputA.Text),
                        b = int.Parse(inputB.Text);

                    print(array);

                    outputResult.Text = "Чисел — " + countNumbers(array, a, b);
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
            for (int z = 0; z < array.Length; ++z) {
                outputArray.Text += array[z] + " ";
            }
        }

        private int[] getArray() {
            string[] infoArray  = input1DArray.Text.Trim().Split(' ');
            int[] array         = new int[input1DArray.Text.Trim().Split(' ').Length];

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
            outputArray.Text = "";

            for (int z = 0; z < array.GetLength(0); ++z) {
                for (int y = 0; y < array.GetLength(1); ++y) {
                    outputArray.Text += array[z, y] + " ";
                }
                outputArray.Text += "\r\n";
            }
        }

        private bool getArray(out int[,] array) {
            string[] infoArray  = input2DArray.Text.Trim().Split('\n');

            int rows            = input2DArray.Text.Trim().Split('\n').Length;
            int columns         = input2DArray.Text.Trim().Split('\n')[0].Split(' ').Length;

            array               = new int[rows, columns];

            string[] row;
            try {
                for (int z = 0; z < array.GetLength(0); ++z) {
                    row = infoArray[z].Split(' ');
                    for (int y = 0; y < array.GetLength(1); ++y) {
                        array[z, y] = int.Parse(row[y]);
                    }
                }
            } catch (Exception) {
                outputArray.Text = "Неверные данные!";

                array = null;
                return false;
            }

            return true;
        }
    }
}
