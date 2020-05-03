using System;

namespace Task_2 {
    class Program {
        static void Main(string[] args) {
            DateTime    date;
            int         amountDays;

            try {
                Console.Write("Введите дату в формате ММ.ДД.ГГГГ — ");
                date = DateTime.Parse(Console.ReadLine());
            } catch (FormatException) {
                Console.WriteLine("Неверный формат данных!");
                return;
            } catch (ArgumentNullException) {
                Console.WriteLine("Пустая строка!");
                return;
            }

            try {
                Console.Write("Сколько дней добавить? — ");
                amountDays = int.Parse(Console.ReadLine());
            } catch (Exception) {
                Console.WriteLine("Проверьте данные!");
                return;
            }

            Console.WriteLine("Итоговая дата — " + date.AddDays(amountDays).ToShortDateString());
        }
    }
}
