using System;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int position1 = 3;
        int position2 = 24;

        int mask1 = 7 << position1;
        int mask2 = 7 << position2;

        int getNumbers1 = number & mask1;
        int getNumbers2 = number & mask2;
        int change = (number & ~mask1) & ~mask2;

        int mask3 = (getNumbers1 >> position1) << position2;
        int mask4 = (getNumbers2 >> position2) << position1;
        int result = (change | mask3) | mask4;

        Console.WriteLine("Binary representation: " + Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Result: " + result);
        Console.WriteLine("Binary result: " + Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}