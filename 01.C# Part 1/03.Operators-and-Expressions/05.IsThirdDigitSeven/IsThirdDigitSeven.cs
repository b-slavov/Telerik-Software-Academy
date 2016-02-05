using System;

class IsThirdDigitSeven
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool checker = ((number / 100) % 10 == 7) || ((number / 100) % 10 == -7);

        Console.WriteLine("The third digit from right-to-left is 7 -> " + checker);
    }
}