using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter two double variables:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        Console.WriteLine(a + " " + b);
    }
}