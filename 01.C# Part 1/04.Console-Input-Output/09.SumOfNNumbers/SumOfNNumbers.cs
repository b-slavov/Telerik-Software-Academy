using System;

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers n you want to calculate: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine("The sum of these {0} numbers is: {1}", n, sum);
    }
}