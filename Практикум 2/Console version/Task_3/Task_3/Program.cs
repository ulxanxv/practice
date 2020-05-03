using System;

namespace Task_3 {
    class Program {
        static void Main(string[] args) {
            int a, b, x, y;

            try {
                Console.Write("Введите A — ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Введите B — ");
                b = int.Parse(Console.ReadLine());

                Console.Write("Введите X — ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Введите X — ");
                y = int.Parse(Console.ReadLine());
            } catch (Exception) {
                Console.WriteLine("Неверные данные!");
                return;
            }

            // Цикл while
            int count = a - 1;
            while (++count <= b) {
                if (count % 10 == x || count % 10 == y) {
                    Console.WriteLine(count + " ");
                }
            }

            // Цикл do while
            count = a;
            do {
                if (count % 10 == x || count % 10 == y) {
                    Console.WriteLine(count + " ");
                }
            } while (++count <= b);

            // Цикл for
            for (count = a; count <= b; ++count) {
                if (count % 10 == x || count % 10 == y) {
                    Console.WriteLine(count + " ");
                }
            }
        }
    }
}
