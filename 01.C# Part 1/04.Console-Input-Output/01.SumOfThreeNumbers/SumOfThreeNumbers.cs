using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        double sum = a + b + c;

        Console.WriteLine("The sum of these three numbers is: " + sum);
    }
}