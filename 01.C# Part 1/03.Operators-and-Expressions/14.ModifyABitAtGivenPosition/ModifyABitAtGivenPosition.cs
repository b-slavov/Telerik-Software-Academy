using System;

class ModifyABit
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a value (0 or 1): ");
        int value = int.Parse(Console.ReadLine());
        Console.Write("Enter a position: ");
        int position = int.Parse(Console.ReadLine());

        if (value == 0)
        {
            int mask = ~(1 << position);
            int result = number & mask;
            Console.WriteLine("Result: " + result);
        }
        else
        {
            int mask = 1 << position;
            int result = number | mask;
            Console.WriteLine("Result: " + result);
        }
    }
}