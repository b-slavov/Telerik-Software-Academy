using System;

class BinaryShort
{
    static string GetShortBinaryString(short n)
    {
        char[] b = new char[16];
        int pos = 15;
        int i = 0;

        while (i < 16)
        {
            if ((n & (1 << i)) != 0)
            {
                b[pos] = '1';
            }
            else
            {
                b[pos] = '0';
            }

            pos--;
            i++;
        }

        return new string(b);
    }

    static void Main()
    {
        Console.Write("Enter 16 bit short number: ");
        short number = short.Parse(Console.ReadLine());

        Console.WriteLine("Binary representation: " + GetShortBinaryString(number));
    }
}