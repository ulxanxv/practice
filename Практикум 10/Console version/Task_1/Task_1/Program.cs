using System;
using System.IO;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {

            if (Directory.Exists(@"C:\temp")) { Directory.Delete(@"C:\temp", true); }

            // 1 пункт задания
            Directory.CreateDirectory(@"C:\temp\K1");
            Directory.CreateDirectory(@"C:\temp\K2");

            // 2 пункт задания
            File.Create(@"C:\temp\K1\t1.txt").Close();
            File.WriteAllText(@"C:\temp\K1\t1.txt", "Иванов Иван Иванович, 1965 года рождения, место жительства г. Саратов");

            File.Create(@"C:\temp\K1\t2.txt").Close();
            File.WriteAllText(@"C:\temp\K1\t2.txt", "Петров Сергей Федорович, 1966 года рождения, место жительства г.Энгельс");

            // 3 пункт задания
            File.Create(@"C:\temp\K2\t3.txt").Close();
            File.WriteAllText(@"C:\temp\K2\t3.txt", File.ReadAllText(@"C:\temp\K1\t1.txt"));
            File.AppendAllText(@"C:\temp\K2\t3.txt", File.ReadAllText(@"C:\temp\K1\t2.txt"));

            // 4 пункт задания
            Console.WriteLine("Информация о — C:\\temp\\K1\\t1.txt");
            Console.WriteLine("Полное имя — " + new FileInfo(@"C:\temp\K1\t1.txt").FullName);
            Console.WriteLine("Дата создания — " + new FileInfo(@"C:\temp\K1\t1.txt").CreationTime);
            Console.WriteLine("Расширение —" + new FileInfo(@"C:\temp\K1\t1.txt").Extension);

            Console.WriteLine("Информация о — C:\\temp\\K1\\t2.txt");
            Console.WriteLine("Полное имя — " + new FileInfo(@"C:\temp\K1\t2.txt").FullName);
            Console.WriteLine("Дата создания — " + new FileInfo(@"C:\temp\K1\t2.txt").CreationTime);
            Console.WriteLine("Расширение —" + new FileInfo(@"C:\temp\K1\t2.txt").Extension);

            Console.WriteLine("Информация о — C:\\temp\\K2\\t3.txt");
            Console.WriteLine("Полное имя — " + new FileInfo(@"C:\temp\K2\t3.txt").FullName);
            Console.WriteLine("Дата создания — " + new FileInfo(@"C:\temp\K2\t3.txt").CreationTime);
            Console.WriteLine("Расширение —" + new FileInfo(@"C:\temp\K2\t3.txt").Extension);

            // 5 пункт задания
            File.Move(@"C:\temp\K1\t2.txt", @"C:\temp\K2\t2.txt");

            // 6 пункт задания
            File.Copy(@"C:\temp\K1\t1.txt", @"C:\temp\K2\t1.txt");

            // 7 пункт задания
            Directory.Move(@"C:\temp\K2", @"C:\temp\All");
            Directory.Delete(@"C:\temp\K1", true);

            // 8 пункт задания
            FileInfo[] fileInfo = new DirectoryInfo(@"C:\temp\All").GetFiles();
            Console.WriteLine("\n\nИнформации о файлах и папках папки \"All\"");
            foreach (FileInfo info in fileInfo) {
                Console.WriteLine("Полное имя — " + info.FullName);
                Console.WriteLine("Дата создания — " + info.CreationTime);
                Console.WriteLine("Расширение —" + info.Extension);
            }
        }
    }
}
