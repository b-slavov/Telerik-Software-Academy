using System;

class ExchangeBits2
{
    static void Main()
    {
        uint number;
        Console.Write("Enter an unsigned integer: ");
        bool checkUInteger = uint.TryParse(Console.ReadLine(), out number);

        if (checkUInteger == false)
        {
            Console.WriteLine("Out of unsigned integer range!");
        }
        else
        {
            Console.Write("First position: ");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Second position: ");
            int q = int.Parse(Console.ReadLine());
            Console.Write("Bits to exchange: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Binary representation: " + Convert.ToString(number, 2).PadLeft(32, '0'));
            int lenght = Math.Min(p, q) + k;

            if (Math.Min(p, q) + k >= Math.Max(p, q))
            {
                Console.WriteLine("Overlapping!");
            }
            else if (p < 0 || q < 0 || p + k > 32 || q + k > 32)
            {
                Console.WriteLine("Out of range!");
            }
            else
            {
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

                Console.WriteLine("Result: " + number);
                Console.WriteLine("Binary representation: " + Convert.ToString(number, 2).PadLeft(32, '0'));
            }
        }
    }
}