using System;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {
            int x, y;

            try {
                Console.Write("Введите x — ");
                x = int.Parse(Console.ReadLine());

                Console.Write("Введите y — ");
                y = int.Parse(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Неверный формат данных!");
                return;
            } catch (OverflowException) {
                Console.WriteLine("Слишком большие числа!");
                return;
            }

            if ((x > -50 && x < 50) && (y < 25 && y > -25)) {
                Console.WriteLine("Точка внутри заштрихованной области!");
            } else if ((x == -50 || x == 50) || (y == 25 || y == -25)) {
                Console.WriteLine("Точка лежит на границе!");
            } else {
                Console.WriteLine("Точка лежит вне заштрихованной области!");
            }
        }
    }
}
