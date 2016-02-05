using System;

class NullValues
{
    static void Main()
    {
        int? a = null;
        double? b = null;

        Console.WriteLine("The value of int? is: " + a);
        Console.WriteLine("The value of double? is: " + b);

        a += 0;
        b += 1.7;

        Console.WriteLine("Result after adding a value to int?: " + a);
        Console.WriteLine("Result after adding a value to double?: " + b);
        Console.WriteLine("Conclusion: Any math operation with null returns null!");
    }
}