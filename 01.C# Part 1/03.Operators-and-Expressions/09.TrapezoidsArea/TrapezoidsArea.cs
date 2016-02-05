using System;
using System.Globalization;
using System.Threading;

class TrapezoidsArea
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter first trapezoid's side: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second trapezoid's side: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the trapezoid's height: ");
        double h = double.Parse(Console.ReadLine());

        double area = ((a + b) / 2) * h;

        Console.WriteLine("The trapezoid's area is: " + area);
    }
}