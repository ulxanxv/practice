using System;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(chainFraction(7, 17));
        }

        static double chainFraction(int x, int n, int count = 0) {
            if (count < n) {
                return x / chainFraction(x, n, count + 1);
            } else {
                return x + n;
            }
        }
    }
}
