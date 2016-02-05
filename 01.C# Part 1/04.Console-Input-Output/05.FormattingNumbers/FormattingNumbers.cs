using System;

class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Enter an integer number (from 0 to 500): ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter first floating-point number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter second floating-point number: ");
        double c = double.Parse(Console.ReadLine());

        Console.Write("{0,-10:X}|", a);
        Console.Write("{0}|", Convert.ToString(a, 2).PadLeft(10, '0'));
        Console.Write(("{0,10:0.##}|"), b);
        Console.WriteLine(("{0,-10:F3}|"), c);
    }
}