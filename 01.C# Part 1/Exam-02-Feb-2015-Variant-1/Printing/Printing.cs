using System;

class Printing
{
    static void Main()
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal s = decimal.Parse(Console.ReadLine());
        decimal p = decimal.Parse(Console.ReadLine());

        decimal realm = 500;
        decimal savedMoney = n * s / realm * p; 

        Console.WriteLine("{0:F2}", savedMoney);
    }
}