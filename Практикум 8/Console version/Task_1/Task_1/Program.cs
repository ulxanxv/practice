using System;
using System.Text.RegularExpressions;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {

            double summa = 0.0;

            Console.Write("Введите строку — ");
            string message = Console.ReadLine();

            // Маска для целочисленных/дробных чисел
            MatchCollection matchesDecimal = new Regex(@"\d+\,?\d*").Matches(message);

            // Маска для чисел в экспоненциальной форме
            MatchCollection matchesExponential = new Regex(@"(\d+\,?\d+)\*10\^(\d+)").Matches(message);

            foreach (Match match in matchesDecimal) {
                try {
                    summa += double.Parse(match.Value);
                } catch { }
            }

            foreach (Group group in matchesExponential) {
                summa += double.Parse(group.Value.Split('*')[0]) * Math.Pow(10, double.Parse(group.Value.Split('^')[1]));
            }

            Console.WriteLine("Сумма всех чисел, найденных в тексте — " + summa);
        }
    }
}
