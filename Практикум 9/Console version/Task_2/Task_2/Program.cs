using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Task_2 {
    class Program {
        static void Main(string[] args) {
            string[] context = File.ReadAllLines("file.txt");

            MatchCollection matches;
            for (int i = 0; i < context.Length; ++i) {
                matches = new Regex(@".*\s.*").Matches(context[i]);

                if (matches.Count > 0) {
                    Console.WriteLine(context[i]);
                }
            }
        }
    }
}
