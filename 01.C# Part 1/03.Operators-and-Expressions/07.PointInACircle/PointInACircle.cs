using System;

class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        double r = 2;
        if ((x * x + y * y) <= r * r)
        {
            Console.WriteLine("yes {0:F2}", Math.Sqrt(x * x + y * y));
        }
        else
        {
            Console.WriteLine("no {0:F2}", Math.Sqrt(x * x + y * y));
        }
    }
}
