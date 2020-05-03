using System;

namespace Task_4 {
    class Program {
        static void Main(string[] args) {
            for (int i = 1; i < 6; ++i) {
                for (int j = 1; j < i + 1; j++) {
                    Console.Write(j + " ");
                } Console.WriteLine();
            }
        }
    }
}
