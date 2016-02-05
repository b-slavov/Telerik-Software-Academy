using System;

class EasterMister
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n;
        int width = (3 * n) - 1;
        int sideDots = n - 1;
        int middleDots = sideDots + 2;

        Console.Write(new string('.', n + 1));
        Console.Write(new string('*', n - 1));
        Console.WriteLine(new string('.', n + 1));

        for (int i = 1; i <= n - 2; i++)
        {
            if (sideDots >= 1)
            {
                Console.Write(new string('.', sideDots));
                Console.Write('*');
                Console.Write(new string('.', middleDots));
                Console.Write('*');
                Console.WriteLine(new string('.', sideDots));
            }
            else
            {
                Console.Write('.');
                Console.Write('*');
                Console.Write(new string('.', width - 2));
                Console.Write('*');
                Console.WriteLine('.');
            }
            sideDots -= 2;
            middleDots += 4;
        }

        Console.Write('.');
        Console.Write('*');
        for (int i = 1; i <= width - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('#');
            }
            else
            {
                Console.Write('.');
            }
        }
        Console.Write('*');
        Console.WriteLine('.');

        Console.Write('.');
        Console.Write('*');
        for (int i = 1; i <= width - 2; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write('.');
            }
            else
            {
                Console.Write('#');
            }
        }
        Console.Write('*');
        Console.WriteLine('.');

        for (int i = 1; i <= n - 2; i++)
        {
            sideDots += 2;
            middleDots -= 4;

            if (sideDots > 1)
            {
                Console.Write(new string('.', sideDots));
                Console.Write('*');
                Console.Write(new string('.', middleDots));
                Console.Write('*');
                Console.WriteLine(new string('.', sideDots));
            }
            else
            {
                Console.Write('.');
                Console.Write('*');
                Console.Write(new string('.', width - 2));
                Console.Write('*');
                Console.WriteLine('.');
            }
        }

        Console.Write(new string('.', n + 1));
        Console.Write(new string('*', n - 1));
        Console.WriteLine(new string('.', n + 1));
    }
}