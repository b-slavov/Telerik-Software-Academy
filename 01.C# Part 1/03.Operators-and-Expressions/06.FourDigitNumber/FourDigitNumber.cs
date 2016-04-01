using System;

class FourDigitNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int fourthDigit = number % 10;
        int thirdDigit = (number / 10) % 10;
        int secondDigit = (number / 100) % 10;
        int firstDigit = (number / 1000) % 10;

        Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("{3}{2}{1}{0}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{3}{0}{1}{2}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{0}{2}{1}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
    }
}
