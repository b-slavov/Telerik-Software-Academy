using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four-digit number: ");
        int number = int.Parse(Console.ReadLine());

        if ((number < 1000) || (number > 9999))
        {
            Console.WriteLine("This is not a four-digit number.");
        }
        else
        {
            int firstDigit = number % 10;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = (number / 100) % 10;
            int fourthDigit = (number / 1000) % 10;

            Console.WriteLine("Sum of digits: " + (firstDigit + secondDigit + thirdDigit + fourthDigit));
            Console.WriteLine("Reversed: " + firstDigit + secondDigit + thirdDigit + fourthDigit);
            Console.WriteLine("Last digit in front: " + firstDigit + fourthDigit + thirdDigit + secondDigit);
            Console.WriteLine("Second and third digits exchanged: " + fourthDigit + secondDigit + thirdDigit + firstDigit);
        }
    }
}