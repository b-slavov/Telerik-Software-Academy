using System;

class CalculateSumOfNXN
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1M;
        int factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += factorial / (decimal)Math.Pow(x, i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}