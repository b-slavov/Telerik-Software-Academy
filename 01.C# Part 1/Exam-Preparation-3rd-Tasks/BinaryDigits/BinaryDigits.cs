using System;

class BinaryDigits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string binary = Convert.ToString(n, 2).PadLeft(16, '0');

        //First row
        for (int i = 0; i <= 15; i++)
        {
            if (binary[i] == '1')
            {
                Console.Write(" # ");
            }
            else
            {
                Console.Write("###");
            }
            if (i != 15)
            {
                Console.Write(' ');
            }
        }

        Console.WriteLine();

        //Second row
        for (int i = 0; i <= 15; i++)
        {
            if (binary[i] == '1')
            {
                Console.Write("## ");
            }
            else
            {
                Console.Write("# #");
            }
            if (i != 15)
            {
                Console.Write(' ');
            }
        }

        Console.WriteLine();

        //Third row
        for (int i = 0; i <= 15; i++)
        {
            if (binary[i] == '1')
            {
                Console.Write(" # ");
            }
            else
            {
                Console.Write("# #");
            }
            if (i != 15)
            {
                Console.Write(' ');
            }
        }

        Console.WriteLine();

        //Fourth row
        for (int i = 0; i <= 15; i++)
        {
            if (binary[i] == '1')
            {
                Console.Write("###");
            }
            else
            {
                Console.Write("###");
            }
            if (i != 15)
            {
                Console.Write(' ');
            }
        }

        Console.WriteLine();
    }
}