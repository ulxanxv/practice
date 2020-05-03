using System;

namespace Task_2 {
    class Program {
        static void Main(string[] args) {
            int number;

            try {
                Console.Write("Введите число — ");
                number = int.Parse(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Вы ввели не число :(");
                return;
            } catch (OverflowException) {
                Console.WriteLine("Число уже превышает int! Может пора остановиться?");
                return;
            }

            if (number < 10 || number > 100) {
                Console.WriteLine("Число не удовлетворяет заданию ;(");
            } else {
                if (((number / 10) + (number % 10)) % 3 == 0) {
                    Console.WriteLine("Сумма цифр кратка трём ;)");
                } else {
                    Console.WriteLine("Сумма цифр не кратка трём ;(");
                }
            }
        }
    }
}
