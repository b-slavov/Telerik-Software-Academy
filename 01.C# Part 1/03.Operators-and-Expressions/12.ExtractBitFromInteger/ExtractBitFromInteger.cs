using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int result = number & mask;
        int bit = result >> position;

        Console.WriteLine("The value of bit {0} from number {1} is {2}", position, number, bit);
    }
}