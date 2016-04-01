using System;

class BitsExchangeAdvanced
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int q = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        
        int lenght = Math.Min(p, q) + k;

        for (; Math.Min(p, q) < lenght; p++, q++)
        {
            uint mask1 = (uint)(number & 1 << p);
            uint mask2 = (uint)(number & 1 << q);

            if (mask1 != 0)
            {
                number = number | (uint)(1 << q);
            }
            else
            {
                number = number & (uint)(~(1 << q));
            }

            if (mask2 != 0)
            {
                number = number | (uint)(1 << p);
            }
            else
            {
                number = number & (uint)(~(1 << p));
            }
        }

        Console.WriteLine(number);
    }
}
