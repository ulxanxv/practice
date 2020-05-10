using System;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace Task_1 {
    class Program {

        public Program() {
            string data = File.ReadAllText("data.xml").Replace('\r', ' ').Replace('\n', ' ');

            Software[] softwares = getSoftwares(data);

            outputSoftwares(softwares);
            findActivatedSoftware(softwares);

        }

        static void Main(string[] args) {
            new Program();
        }

        /// <summary>
        /// Поиск активированного ПО
        /// </summary>
        /// <param name="softwares"></param>
        private void findActivatedSoftware(Software[] softwares) {
            Console.WriteLine
                (
                    "\n\n||—————————————————||\n" +
                    "||АКТИВИРОВАННОЕ ПО||\n" +
                    "||—————————————————||\n"
                );


            for (int i = 0; i < softwares.Length; ++i) {
                if (softwares[i].use()) {
                    Console.WriteLine("Информация о " + softwares[i].ToString());
                    softwares[i].info(); 
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Вывод всех ПО
        /// </summary>
        /// <param name="softwares"></param>
        private void outputSoftwares(Software[] softwares) {
            Console.WriteLine
                (
                    "||—————————————————||\n" +
                    "||    СПИСОК ПО    ||\n" +
                    "||—————————————————||\n"
                );


            for (int i = 0; i < softwares.Length; ++i) {
                Console.WriteLine("Информация о " + softwares[i].ToString());
                softwares[i].info();
                Console.WriteLine("Можно ли использовать дальше? " + (softwares[i].use() ? "Да" : "Нет"));
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Чтение из строки в массив
        /// </summary>
        private Software[] getSoftwares(string data) {
            // Бесплатное ПО
            MatchCollection freewares = Regex.Matches(data, "<freeware>(.*?)</freeware>");
            // Условно-бесплатное ПО
            MatchCollection sharewares = Regex.Matches(data, "<shareware>(.*?)</shareware>");
            // Платное ПО
            MatchCollection commercialSoftwares = Regex.Matches(data, "<commercialsoftware>(.*?)</commercialsoftware>");

            int size                = freewares.Count + sharewares.Count + commercialSoftwares.Count,
                softwaresSize       = 0;

            Software[] softwares    = new Software[size];

            for (int x = 0; x < freewares.Count; ++x) {

                softwares[softwaresSize++] = new Freeware
                    (
                        Regex.Match(freewares[x].Value, "<name>(.*?)</name>").Groups[1].Value,
                        Regex.Match(freewares[x].Value, "<producer>(.*?)</producer>").Groups[1].Value
                    );

            }

            for (int x = 0; x < sharewares.Count; ++x) {

                softwares[softwaresSize++] = new Shareware
                    (
                        DateTime.Parse  (Regex.Match(sharewares[x].Value, "<activationDate>(.*?)</activationDate>").Groups[1].Value),
                        int.Parse       (Regex.Match(sharewares[x].Value, "<howDays>(.*?)</howDays>").Groups[1].Value),
                        Regex.Match     (sharewares[x].Value, "<name>(.*?)</name>").Groups[1].Value,
                        Regex.Match     (sharewares[x].Value, "<producer>(.*?)</producer>").Groups[1].Value,
                        DateTime.Parse  (Regex.Match(sharewares[x].Value, "<installDate>(.*?)</installDate>").Groups[1].Value),
                        int.Parse       (Regex.Match(sharewares[x].Value, "<freeTerm>(.*?)</freeTerm>").Groups[1].Value)
                    );

            }

            for (int x = 0; x < commercialSoftwares.Count; ++x) {

                softwares[softwaresSize++] = new CommercialSoftware
                    (
                        DateTime.Parse  (Regex.Match(commercialSoftwares[x].Value, "<activationDate>(.*?)</activationDate>").Groups[1].Value),
                        int.Parse       (Regex.Match(commercialSoftwares[x].Value, "<howDays>(.*?)</howDays>").Groups[1].Value),
                        Regex.Match     (commercialSoftwares[x].Value, "<name>(.*?)</name>").Groups[1].Value,
                        Regex.Match     (commercialSoftwares[x].Value, "<producer>(.*?)</producer>").Groups[1].Value,
                        DateTime.Parse  (Regex.Match(commercialSoftwares[x].Value, "<installDate>(.*?)</installDate>").Groups[1].Value),
                        double.Parse    (Regex.Match(commercialSoftwares[x].Value, "<price>(.*?)</price>").Groups[1].Value),
                        int.Parse       (Regex.Match(commercialSoftwares[x].Value, "<useTerm>(.*?)</useTerm>").Groups[1].Value)
                    );

            }

            return softwares;
        }

    }
}
