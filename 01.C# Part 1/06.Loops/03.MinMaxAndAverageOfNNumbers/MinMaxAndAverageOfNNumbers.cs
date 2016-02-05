using System;
using System.Linq;

class MinMaxAndAverageOfNNumbers
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[] sequence = new int[n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Element[{0}] = ", i);
            sequence[i] = int.Parse(Console.ReadLine());
            sum += sequence[i];
        }

        decimal average = (decimal)sum / n;
        Array.Sort(sequence);

        Console.WriteLine("min = {0}", sequence.First());
        Console.WriteLine("max = {0}", sequence.Last());
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", average);
    }
}