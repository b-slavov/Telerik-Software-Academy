using System;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter number of members to print: ");
        int members = int.Parse(Console.ReadLine());

        long firstPrevious = -1;
        long secondPrevious = 1;
        long sum = 0;
        for (int i = 0; i < members; i++)
        {
            sum = firstPrevious + secondPrevious;
            if (i == members - 1)
            {
                Console.WriteLine(sum);
            }
            else
            {
                Console.Write(sum + ", ");
            }

            firstPrevious = secondPrevious;
            secondPrevious = sum;
        }
    }
}