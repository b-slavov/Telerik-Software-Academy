using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool isOdd = number % 2 == 0 ? false : true;

        Console.WriteLine("Odd? -> " + isOdd);
    }
}