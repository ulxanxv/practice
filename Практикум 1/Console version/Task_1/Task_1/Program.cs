using System;
class Program {
    static void Main(string[] args) {
        double  x1, x2,
                y1, y2,
                z1, z2;


        Console.Write("Введите x_1 — ");
        double.TryParse(Console.ReadLine(), out x1);
        Console.Write("Введите x_2 — ");
        double.TryParse(Console.ReadLine(), out x2);

        Console.Write("Введите y_1 — ");
        double.TryParse(Console.ReadLine(), out y1);
        Console.Write("Введите y_2 — ");
        double.TryParse(Console.ReadLine(), out y2);

        Console.Write("Введите z_1 — ");
        double.TryParse(Console.ReadLine(), out z1);
        Console.Write("Введите z_2 — ");
        double.TryParse(Console.ReadLine(), out z2);


        double peremeter =  Math.Sqrt(Math.Pow(y1 - x1, 2) + Math.Pow(y2 - x2, 2)) +
                            Math.Sqrt(Math.Pow(z1 - y1, 2) + Math.Pow(z2 - y2, 2)) +
                            Math.Sqrt(Math.Pow(x1 - z1, 2) + Math.Pow(x2 - z2, 2));

        Console.WriteLine("Периметр равен — {0}", peremeter);
    }
}
