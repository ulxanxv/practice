using System;

namespace Task_2 {
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

            for (double i = a; i <= b; i += h) {
                Console.WriteLine("f({0:f2}) = {1:f4}", i, foo(i));
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
    }
}
