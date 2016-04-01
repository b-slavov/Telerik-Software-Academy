using System;

class ExtractBitFromInteger
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int result = number & mask;
        int bit = result >> position;

        Console.WriteLine(bit);
    }
}
