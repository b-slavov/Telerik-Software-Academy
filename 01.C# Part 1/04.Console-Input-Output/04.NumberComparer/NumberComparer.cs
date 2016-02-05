using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int secondNumber = int.Parse(Console.ReadLine());

        int greaterNumber = Math.Max(firstNumber, secondNumber);

        Console.WriteLine("Greater number is: " + greaterNumber);
    }
}
