using System;

namespace Task_2 {
    class Program {
        static void Main(string[] args) {
            int[] array;

            do {
                array = getArray();
            } while (array == null);

            Console.Write("\nВаш массив — ");
            print(array);

            Console.WriteLine("\n\nПоследнее позиция минимального числа — " + lastMinimal(array));
        }

        static void print(int[] array) {
            for (int z = 0; z < array.Length; ++z) {
                Console.Write(array[z] + " ");
            }
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
    }
}
