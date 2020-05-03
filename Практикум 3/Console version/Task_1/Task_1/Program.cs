using System;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Тестирование с числом 10 — " + foo(10));
            Console.WriteLine("Тестирование с числом 11 — " + foo(11));
        }

        private static int foo(int x) {
            if (x % 5 == 0) {
                return x / 5;
            } else {
                return x + 1;
            }
        }
    }
}
