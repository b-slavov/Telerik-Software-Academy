using System;

class FormatNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("{0,15:D} -> Decimal", number);
        Console.WriteLine("{0,15:X} -> Hexadecimal", number);
        Console.WriteLine("{0,15:P} -> Percentage", number);
        Console.WriteLine("{0,15:E} -> Scientific notation", number);
    }
}