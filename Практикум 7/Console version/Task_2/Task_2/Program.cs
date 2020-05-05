using System;
using System.Linq;

namespace Task_2 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Введите ваше сообщение — ");
            string[] allWords = new string(Console.ReadLine().Where(x => Char.IsLetter(x) && !Char.IsPunctuation(x) || x == ' ').ToArray()).Split(' ');

            int maxLength = 0, index = 0;
            for (int i = 0; i < allWords.Length; ++i) {
                if (allWords[i].Length > maxLength) {
                    maxLength = allWords[i].Length;
                    index = i;
                }
            }

            Console.Write("Самое длиное слово — " + allWords[index]);
        }
    }
}
