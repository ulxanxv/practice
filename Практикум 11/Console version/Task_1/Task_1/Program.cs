using System;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Введите дату в формате ДД.ММ.ГГГГ — ");
            DateWork date = new DateWork(Console.ReadLine());

            Console.WriteLine("\nВчерашняя дата — " + date.yesterdayDate());
            Console.WriteLine("Завтряшняя дата — " + date.tomorrowDate());
            Console.WriteLine("До конца месяца {0} суток", date.howEnd());
            Console.WriteLine(date.LeapYear ? "Год вискосный" : "Год не високосный");
            Console.WriteLine("Дата — " + date.Date);

            Console.Write("\nВведите новую дату в формате ДД.ММ.ГГГГ — ");
            try {
                date.Date = DateTime.Parse(Console.ReadLine());
            } catch (Exception) {
                Console.WriteLine("Дата была введена неверно — будет установлена дата 01.01.2009");
                date.Date = DateTime.Parse("01.01.2009");
            }

            Console.WriteLine("\nИзмененая дата — " + date.Date);
        }
    }
}
