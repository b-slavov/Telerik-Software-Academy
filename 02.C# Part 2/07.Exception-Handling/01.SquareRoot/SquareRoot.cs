using System;

class SquareRoot
{
    public static double Sqrt(double value)
    {
        if (value < 0)
        {
            throw new ArgumentOutOfRangeException("Number must be positive!");
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
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}
