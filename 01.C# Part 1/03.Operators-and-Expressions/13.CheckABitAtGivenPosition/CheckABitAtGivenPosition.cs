using System;

class CheckABitAtGivenPosition
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int result = number & mask;
        int bit = result >> position;
        bool value = (bit == 1);

        Console.WriteLine("Bit {0} in number {1} is 1 -> {2}", position, number, value);
    }
}