using System;
using System.Windows.Forms;

namespace Task_1 {
    public partial class Main : Form {
        public Main() {
            InitializeComponent();

            // Обработчик на нажатие по кнопке
            resultButton.Click += OutButton_Click;

            // Всплывающая подсказка о том, как вводить массив
            toolTip1.SetToolTip(this.inputArray, "Пример ввода массива — \n1 4 6\n3 2 5\n1 2 4");
        }

        private void OutButton_Click(object sender, EventArgs e) {
            result();
        }

        private int[,] powMatrix(int[,] matrix, int pow) {
            int[,] bufferMatrix         = matrix,
                   multiplicationMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            int summa = 0;

            if (pow < 2) { return matrix; }

            while (--pow > 0) {
                for (int i = 0; i < matrix.GetLength(0); ++i) {
                    for (int j = 0, l = 0; j < bufferMatrix.GetLength(0); ++j) {
                        for (int k = 0; k < bufferMatrix.GetLength(1); ++k) {
                            summa += bufferMatrix[j, k] * matrix[k, i];
                        }
                        multiplicationMatrix[l++, i] = summa;
                        summa = 0;
                    }
                }
                bufferMatrix = (int[,])multiplicationMatrix.Clone();
            }
            return multiplicationMatrix;
        }

        private void result() {
            int[,] array;

            array = getArray();

            if (array != null) {
                try {
                    print(powMatrix(array, Convert.ToInt32(multi.Value)));
                } catch (Exception) {
                    outputArray.Text = "Неверный диапазон значений!";
                    return;
                }
            }
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
                outputArray.Text = "Неверные данные!";
                return null;
            }

            return array;
        }
    }
}
