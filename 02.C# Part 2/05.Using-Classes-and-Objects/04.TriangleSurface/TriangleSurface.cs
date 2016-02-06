using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Chose calculation");
        Console.WriteLine("1.Side and an altitude to it");
        Console.WriteLine("2.Three sides");
        Console.WriteLine("3.Two sides and an angle between them");

        char ch = Console.ReadKey().KeyChar;

        Console.WriteLine();

        switch (ch)
        {
            case '1':
                Console.Write("Enter side: ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("Enter altitude to it: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Area is {0}", (c * d) / 2);
                break;

            case '2':
                Console.Write("Enter side a: ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Enter side b: ");
                double y = double.Parse(Console.ReadLine());
                Console.Write("Enter side c: ");
                double z = double.Parse(Console.ReadLine());
                double p = (x + y + z) / 2;
                Console.WriteLine("Area is {0}", Math.Sqrt(p * (p - x) * (p - y) * (p - z)));
                break;

            case '3':
                Console.Write("Enter side a: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Enter side b: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Enter angle: ");
                double angle = double.Parse(Console.ReadLine());
                Console.WriteLine("Area is {0}", (a * b * Math.Sin(angle)) / 2);
                break;

            default:
                break;
        }
    }
}