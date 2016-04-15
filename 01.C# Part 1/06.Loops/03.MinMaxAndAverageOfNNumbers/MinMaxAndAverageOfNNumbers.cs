using System;
using System.Linq;

class MinMaxAndAverageOfNNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal[] sequence = new decimal[n];
        decimal sum = 0;

        for (int i = 0; i < n; i++)
        {
            sequence[i] = decimal.Parse(Console.ReadLine());
            sum += sequence[i];
        }

        decimal average = (decimal)sum / n;
        Array.Sort(sequence);

        Console.WriteLine("min={0:F2}", sequence.First());
        Console.WriteLine("max={0:F2}", sequence.Last());
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", average);
    }
}