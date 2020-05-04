using System;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {
            int a, b, h;

            try {
                Console.Write("Введите a — ");
                a = int.Parse(Console.ReadLine());

                Console.Write("Введите b — ");
                b = int.Parse(Console.ReadLine());

                Console.Write("Введите h — ");
                h = int.Parse(Console.ReadLine());

                for (double i = a; i <= b; i += h) {
                    try {
                        Console.WriteLine(foo(i));
                    } catch {
                        Console.WriteLine("Функция не опредлена в значении x = " + i);
                    }
                }
            } catch (Exception) {
                Console.WriteLine("Неверный формат данных!");
            }
        }

        static double foo(double x) {
            if (x == 2 || x - 2 < 0) {
                throw new FormatException();
            } else { 
                return Math.Abs(Math.Log10(x - 2)); 
            }
        }
    }
}
