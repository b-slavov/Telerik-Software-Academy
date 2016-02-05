using System;
using System.Text;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter starting number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter ending number: ");
        int end = int.Parse(Console.ReadLine());

        int p = 0;
        var output = new StringBuilder();

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0)
            {
                p++;
                output.Append(i).Append(", ");
            }
        }

        output.Remove(output.Length - 2, 2);

        Console.WriteLine("{0} numbers between {1} and {2}: {3}", p, start, end, output);
    }
}