using System;

namespace Task_2 {
    class Program {
        static void Main(string[] args) {
            int a, b;
            int[,] array;

            do {
                array = getArray();
            } while (array == null);

            Console.Write("\nВаш массив:\n");
            print(array);

            try {
                Console.Write("\n\nВведите a — ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Введите b — ");
                b = int.Parse(Console.ReadLine());
            } catch (Exception) {
                Console.WriteLine("Проверьте данные!");
                return;
            }

            Console.WriteLine("\n| Чисел, входящих в данный диапазон, в массиве — " + countNumbers(array, a, b));
        }

        static int countNumbers(int[,] array, int a, int b) {
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
            int     rows, columns;

            try {
                Console.Write("Введите количество строк — ");
                rows = int.Parse(Console.ReadLine());
                
                Console.Write("Введите количество столбцов — ");
                columns = int.Parse(Console.ReadLine());

                array = new int[rows, columns];
            } catch (Exception) {
                Console.WriteLine("Неверный формат данных");
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
