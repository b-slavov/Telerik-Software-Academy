using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("The numbers in the interval [1..{0}] are: ", n);
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}