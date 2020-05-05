using System;
using System.Text;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {
            StringBuilder str = new StringBuilder();
            string substring1, substring2;
            
            Console.Write("Введите строку — ");
            str.Append(Console.ReadLine());

            Console.Write("Введите подстрку, которую нужно заменить — ");
            substring1 = Console.ReadLine();
            Console.Write("Введите подстрку, на которую нужно заменить — ");
            substring2 = Console.ReadLine();

            /*
            * Можно и так — str.Replace(substring1, substring2);
            */

            int countEntries = 0;
            for (int i = 0; i < str.Length; ++i) {      
                if (str[i] == substring1[0]) {            
                    for (int j = i, k = 0; j < str.Length && k < substring1.Length; ++j, ++k) {
                        if (str[j] == substring1[k]) {
                            countEntries++;
                        } else {
                            break;
                        }
                    }
            
                    if (countEntries == substring1.Length) {
                        str.Remove(i, substring1.Length);
                        str.Insert(i, substring2);
                    }
            
                    countEntries = 0;
                }             
            }

            Console.WriteLine("\nИтоговая строка — " + str);
        }
    }
}
