using System;

namespace Task_3 {
    class Program {
        static void Main(string[] args) {
            int[,]  matrix;
            int     multi;

            Console.WriteLine("Введите матрицу:\n");
            do {
                matrix = getArray();
            } while (matrix == null);

            Console.WriteLine("\nВаша матрица: ");
            print(matrix);

            try {
                Console.Write("\nВведите степень возведения — ");
                multi = int.Parse(Console.ReadLine());
            } catch (Exception) {
                Console.WriteLine("Неверный формат данных!");
                return;
            }

            Console.WriteLine("\nВозведенная в " + multi + " степень матрица:");
            print(powMatrix(matrix, multi));
        }

        static int[,] powMatrix(int[,] matrix, int pow) {
            int[,] bufferMatrix         = matrix,
                   multiplicationMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            int summa = 0;

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

        static void print(int[,] array) {
            for (int z = 0; z < array.GetLength(0); ++z) {
                for (int y = 0; y < array.GetLength(1); ++y) {
                    Console.Write(array[z, y] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[,] getArray() {
            int[,] array;
            int rows, columns;

            try {
                Console.Write("Введите количество строк — ");
                rows = int.Parse(Console.ReadLine());

                Console.Write("Введите количество столбцов — ");
                columns = int.Parse(Console.ReadLine());

                array = new int[rows, columns];
            } catch (Exception) {
                Console.WriteLine("Неверный формат данных\n");
                return null;
            }

            Console.WriteLine();
            for (int z = 0; z < rows; ++z) {
                for (int y = 0; y < columns; ++y) {
                    Console.Write("Введите [{0}:{1}] элемент массива — ", z, y);

                    // Ввод элемента до тех пор, пока не будет введен допустимый
                    while (!int.TryParse(Console.ReadLine(), out array[z, y])) {
                        Console.Write("Введите [{0}:{1}] элемент массива — ", z, y);
                    };
                }
            }

            return array;
        }
    }
}
