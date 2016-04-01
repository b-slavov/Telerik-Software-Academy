using System;

class DivideBySevenAndFive
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool checker = (number % 7 == 0) && (number % 5 == 0);
        if (checker)
        {
            Console.WriteLine("true " + number);
        }
        else
        {
            Console.WriteLine("false " + number);
        }
    }
}
