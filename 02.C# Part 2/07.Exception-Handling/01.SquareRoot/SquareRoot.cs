using System;

class SquareRoot
{
    public static double Sqrt(double value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException("Invalid number");
        }

        return Math.Sqrt(value);
    }


    static void Main()
    {
        string number = Console.ReadLine();

        try
        {
            double n = double.Parse(number);

            double sqrt = Sqrt(n);

            Console.WriteLine("{0:F3}", sqrt);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid number");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
