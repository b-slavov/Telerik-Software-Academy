using System;
using System.Globalization;
using System.Threading;

class PointInsideACircleAndOutsideOfARectangle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter point x: ");
        decimal x = decimal.Parse(Console.ReadLine());
        Console.Write("Enter point y: ");
        decimal y = decimal.Parse(Console.ReadLine());

        decimal centerX = 1m;
        decimal centerY = 1m;
        decimal r = 1.5m;

        decimal leftX = -1m;
        decimal rightX = 5m;
        decimal topY = 1m;
        decimal bottomY = -1m;

        bool isInCircle = ((x - centerX) * (x - centerX)) + ((y - centerY) * (y - centerY)) <= (r * r);
        bool isOutsideOfRectangle = (x <= leftX || x >= rightX) && (y >= topY || y <= bottomY);

        bool result = isInCircle && isOutsideOfRectangle;

        if (result)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}