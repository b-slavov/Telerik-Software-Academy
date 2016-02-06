using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Is year leap? {0}", DateTime.IsLeapYear(year));
    }
}