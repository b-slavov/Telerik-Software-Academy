using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool checker = (number % 7 == 0) && (number % 5 == 0);

        Console.WriteLine("This number can be divided by 7 and 5 -> " + checker);
    }
}