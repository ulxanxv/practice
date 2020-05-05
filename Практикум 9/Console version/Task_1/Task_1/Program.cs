using System;
using System.IO;

namespace Task_1 {
    class Program {
        static void Main(string[] args) {

            if (File.Exists("file.dat")) { File.WriteAllText("file.dat", ""); }

            FileStream file             = new FileStream("file.dat", FileMode.OpenOrCreate);
            BinaryWriter binaryWriter   = new BinaryWriter(file);
            BinaryReader binaryReader;

            int size;

            try {
                Console.Write("Введите количество чисел, которые хотите добавить — ");
                size = int.Parse(Console.ReadLine());

                // Числа заполняются рандомные
                Random random = new Random();
                for (int i = 0; i < size; ++i) {
                    binaryWriter.Write(random.NextDouble() * 1000);
                }
				
				binaryWriter.Close();

                file                = new FileStream("file.dat", FileMode.Open);
                binaryReader        = new BinaryReader(file);
                long byteInStream   = file.Length;

                double number, maxNumber;

                try {
                    Console.Write("Введите число, выше которого нельзя выводить — ");
                    maxNumber = double.Parse(Console.ReadLine());
                } catch (Exception) {
                    Console.WriteLine("Неверный формат числа");
                    return;
                }

                for (long i = 0; i < byteInStream; i += 16) {
                    file.Seek(i, SeekOrigin.Begin);

                    number = binaryReader.ReadDouble();

                    if (number < maxNumber) {
                        Console.WriteLine("{0:f2}", number);
                    }
                }
				
				binaryReader.Close();
                file.Close();

            } catch (Exception) {
                Console.WriteLine("Неверный формат данных!");
                return;
            }
        }
    }
}
