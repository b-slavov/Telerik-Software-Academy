using System;

class AmericanPie
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        long nominator = (a * d) + (b * c);
        long denominator = b * d;

        if ((nominator / denominator) >= 1)
        {
            Console.WriteLine(nominator / denominator);
        }
        else if (nominator / denominator < 1)
        {
            Console.WriteLine("{0:F20}", ((decimal)nominator / denominator));
        }
    }
}