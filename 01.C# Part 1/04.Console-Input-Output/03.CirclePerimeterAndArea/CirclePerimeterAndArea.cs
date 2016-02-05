using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the circle's radius: ");
        double r = double.Parse(Console.ReadLine());

        double p = 2 * Math.PI * r;
        double s = Math.PI * r * r;

        Console.WriteLine("The circle's perimeter is: {0:0.00}", p);
        Console.WriteLine("The circle's area is: {0:0.00}", s);
    }
}