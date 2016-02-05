using System;
using System.Globalization;
using System.Threading;

class Rectangles
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter the rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter the rectangle's height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = 2 * (width + height);
        double area = width * height;

        Console.WriteLine("The rectangle's perimeter is: " + perimeter);
        Console.WriteLine("The rectangle's area is: " + area);
    }
}