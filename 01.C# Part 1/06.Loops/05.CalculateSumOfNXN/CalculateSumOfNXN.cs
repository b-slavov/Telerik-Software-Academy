using System;

class CalculateSumOfNXN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        int factorial = 1;
        double power = 1;
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power *= x;
            sum += factorial / power;
        }

        Console.WriteLine("{0:F5}", sum);
    }
}