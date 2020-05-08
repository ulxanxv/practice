using System;

namespace Task_4 {
    class Program {
        static void Main(string[] args) {
            int[][] array = getArray();

            Console.WriteLine("\nВаш массив: ");
            print(array);

            Console.Write("\nИтоговый массив — ");
            print(getRArray(array));
            Console.WriteLine();
        }

        static int[] getRArray(int[][] array) {
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

        static void print(int[][] array) {
            for (int z = 0; z < array.Length; ++z) {
                for (int y = 0; y < array[z].Length; ++y) {
                    Console.Write(array[z][y] + " ");
                }
                Console.WriteLine();
            }
        }

        static void print(int[] array) {
            for (int z = 0; z < array.GetLength(0); ++z) {
                Console.Write(array[z] + " ");
            }
        }

        static int[][] getArray() {
            int[][] array;
            int size;

            try {
                Console.Write("Введите размерность массива — ");
                size = int.Parse(Console.ReadLine());

                array = new int[size][];
                for (int i = 0; i < size; ++i) {
                    array[i] = new int[size];
                }
            } catch (Exception) {
                Console.WriteLine("Неверный формат данных\n");
                return null;
            }

            Console.WriteLine();
            for (int z = 0; z < size; ++z) {
                for (int y = 0; y < size; ++y) {
                    Console.Write("Введите [{0}:{1}] элемент массива — ", z, y);

                    // Ввод элемента до тех пор, пока не будет введен допустимый
                    while (!int.TryParse(Console.ReadLine(), out array[z][y])) {
                        Console.Write("Введите [{0}:{1}] элемент массива — ", z, y);
                    };
                }
            }

            return array;
        }
    }
}
