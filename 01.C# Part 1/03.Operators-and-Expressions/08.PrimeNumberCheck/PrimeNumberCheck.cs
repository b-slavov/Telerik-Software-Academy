using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        bool prime = true;
        if (number < 2)
        {
            prime = false;
        }
        else
        {
            for (int i = 2; i <= (int)Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    prime = false;
                }
            }
        }

        Console.WriteLine(number + " is prime -> " + prime);
    }
}