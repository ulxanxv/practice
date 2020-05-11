using System;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {
            int a, b;
            int[] array;

            // Работа с одномерным массивом
            Console.WriteLine("ОДНОМЕРНЫЙ МАССИВ");

            do {
                array = getArray();
            } while (array == null);

            Console.Write("\nВаш массив — ");
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

            // Работа с двумерным массивом
            Console.WriteLine("\n\nДВУМЕРНЫЙ МАССИВ");

            int[,] newArray;

            do {
                getArray(out newArray);
            } while (newArray == null);

            Console.Write("\nВаш массив — ");
            print(newArray);

            try {
                Console.Write("\n\nВведите a — ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Введите b — ");
                b = int.Parse(Console.ReadLine());
            } catch (Exception) {
                Console.WriteLine("Проверьте данные!");
                return;
            }

            Console.WriteLine("\n| Чисел, входящих в данный диапазон, в массиве — " + countNumbers(newArray, a, b));
        }

        static int countNumbers(int[] array, int a, int b) {
            int count = 0;

            for (int z = 0; z < array.Length; ++z) {
                if (a <= array[z] && array[z] <= b) {
                    ++count;
                }
            }

            return count;
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

        static void print(int[] array) {
            for (int z = 0; z < array.Length; ++z) {
                Console.Write(array[z] + " ");
            }
        }

        static void print(int[,] array) {
            Console.WriteLine();

            for (int z = 0; z < array.GetLength(0); ++z) {
                for (int y = 0; y < array.GetLength(1); ++y) {
                    Console.Write(array[z, y] + " ");
                }
                Console.WriteLine();
            }
        }

        static int[] getArray() {
            int size;

            Console.Write("Введите размер массива — ");
            if (int.TryParse(Console.ReadLine(), out size)) {
                int[] array;
                try {
                    array = new int[size];
                } catch (OverflowException) {
                    return null;
                }

                Console.WriteLine();
                for (int z = 0; z < size; ++z) {
                    Console.Write("Введите {0} элемент массива — ", z);

                    // Ввод элемента до тех пор, пока не будет введен допустимый
                    while (!int.TryParse(Console.ReadLine(), out array[z])) {
                        Console.Write("Введите {0} элемент массива — ", z);
                    };
                }

                return array;
            } else {
                return null;
            }
        }

        static bool getArray(out int[,] array) {
            int rows, columns;

            try {
                Console.Write("Введите количество строк — ");
                rows = int.Parse(Console.ReadLine());

                Console.Write("Введите количество столбцов — ");
                columns = int.Parse(Console.ReadLine());

                array = new int[rows, columns];
            } catch (Exception) {
                Console.WriteLine("Неверный формат данных\n");

                array = null;
                return false;
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

            return true;
        }

    }
}