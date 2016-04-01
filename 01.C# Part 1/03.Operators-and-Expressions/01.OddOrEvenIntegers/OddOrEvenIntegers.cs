using System;

class OddOrEvenIntegers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        bool isOdd = number % 2 == 0 ? false : true;
        if (isOdd)
        {
            Console.WriteLine("odd " + number);
        }
        else
        {
            Console.WriteLine("even " + number);
        }
    }
}
