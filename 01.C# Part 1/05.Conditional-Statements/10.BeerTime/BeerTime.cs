using System;

class BeerTime
{
    static void Main()
    {
        Console.Write("Enter a time in format “hh:mm tt”: ");
        DateTime isBeerTime = DateTime.Parse(Console.ReadLine());

        if (isBeerTime.Hour < 13 && isBeerTime.Hour >= 3)
        {
            Console.WriteLine("non-beer time");
        }
        else
        {
            Console.WriteLine("beer time");
        }
    }
}