using System;
using System.Globalization;
using System.Threading;

class PointInACircle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter x coordinate: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter y coordinate: ");
        double y = double.Parse(Console.ReadLine());

        double r = 2;
        if ((x * x + y * y) <= r * r)
        {
            Console.WriteLine("Point with coordinates x = {0} and y = {1} is within the circle K({0, 0}, 2)", x, y);
        }
        else
        {
            Console.WriteLine("Point with coordinates x = {0} and y = {1} is out of the circle K({0, 0}, 2)", x, y);
        }
    }
}