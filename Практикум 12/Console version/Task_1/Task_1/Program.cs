using System;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {
            DateWork dateWork, dateWork2;

            Console.Write("Введите первую дату (формат ДД.ММ.ГГГГ) — ");
            dateWork = (DateWork)Console.ReadLine();

            Console.Write("Введите вторую дату (формат ДД.ММ.ГГГГ) — ");
            dateWork2 = (DateWork)Console.ReadLine();

            int days;

            Console.Write("\nВведите количество дней — ");
            days = int.Parse(Console.ReadLine());

            Console.Write("Дата — ");
            Console.WriteLine(dateWork[days] + "\n");

            if (dateWork & dateWork2) {
                Console.WriteLine("Объекты равны");
            } else {
                Console.WriteLine("Не равны");
            }

            if (dateWork) {
                Console.WriteLine("Дата является началом года");
            } else {
                Console.WriteLine("Дата не является началом года");
            }

            if (!dateWork) {
                Console.WriteLine("Дата не является последним днем месяца");
            } else {
                Console.WriteLine("Дата является последним днем месяца");
            }

            Console.WriteLine("Приведение типа DateWork в тип string " + (string)dateWork);
        }
    }
}
