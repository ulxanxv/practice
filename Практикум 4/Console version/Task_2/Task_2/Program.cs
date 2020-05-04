using System;

namespace Task_2 {
    class Program {
        static void Main(string[] args) {
            convertToDecimal("11011010100");
        }

        static void convertToDecimal(string binary, int decimalNumber = 0) {
            if (binary.Length != 0) {
                decimalNumber   += int.Parse(binary[0].ToString()) * (int)Math.Pow(2, binary.Length - 1);
                binary          = binary.Substring(1, binary.Length - 1);

                convertToDecimal(binary, decimalNumber);
            } else {
                Console.WriteLine("Десятичное число — " + decimalNumber);
            }
        }
    }
}
