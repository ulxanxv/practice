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

        private void result() {
            int[] readyArray;
            int[][] array;

            array       = getArray();
            readyArray  = newArray(array);

            if (array != null) {
                try {
                    outputArray.Text = "Ваш массив:\r\n";
                    print(array);

                    outputArray.Text += "\r\nИтоговый массив:\r\n";
                    print(readyArray);
                } catch (Exception) {
                    outputArray.Text = "Неверный диапазон значений!";
                    return;
                }
            }
        }

        static int[] newArray(int[][] array) {
            int[] readyArray = new int[array.Length];

            for (int z = 0; z < array.Length; ++z) {
                for (int y = array[z].Length - 1; y > -1; --y) {
                    if (array[z][y] % 2 == 0) {
                        readyArray[z] = array[z][y];
                        break;
                    }
                }
            }

            return readyArray;
        }

        private void print(int[][] array) {
            for (int z = 0; z < array.Length; ++z) {
                for (int y = 0; y < array[z].Length; ++y) {
                    outputArray.Text += array[z][y] + " ";
                }
                outputArray.Text += "\r\n";
            }
        }

        private void print(int[] array) {
            for (int z = 0; z < array.GetLength(0); ++z) {
                outputArray.Text += array[z] + " ";
            }
        }

        private int[][] getArray() {
            int size            = inputArray.Text.Trim().Split('\n').Length;

            // Заполнение
            int[][] array       = new int[size][];
            for (int i = 0; i < size; ++i) {
                array[i] = new int[size];
            }

            string[] infoArray  = inputArray.Text.Trim().Split('\n');

            string[] row;
            try {
                for (int z = 0; z < array.Length; ++z) {
                    row = infoArray[z].Split(' ');
                    for (int y = 0; y < array[z].Length; ++y) {
                        array[z][y] = int.Parse(row[y]);
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
