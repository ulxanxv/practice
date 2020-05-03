using System;

namespace Task_3 {
    class Program {
        static void Main(string[] args) {
            double a, b, h;

            try {
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());

                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());

                Console.Write("h = ");
                h = double.Parse(Console.ReadLine());
            } catch (Exception) {
                Console.WriteLine("Неверный формат данных!");
                return;
            }

            double y;
            for (double i = a; i <= b; i += h) {
                foo(i, out y);
                Console.WriteLine("f({0:f2}) = {1:f4}", i, y);
            }

        }

        private static double foo(double x) {
            if (x + 2 <= 1) {
                return x * x;
            } else if (1 < (x + 2) && (x + 2) < 10) {
                return 1 / (x + 2);
            } else {
                return x + 2;
            }
        }

        private static void foo(double x, out double y) {
            if (x + 2 <= 1) {
                y = x * x;
            } else if (1 < (x + 2) && (x + 2) < 10) {
                y = 1 / (x + 2);
            } else {
                y = x + 2;
            }
        }
    }
}
