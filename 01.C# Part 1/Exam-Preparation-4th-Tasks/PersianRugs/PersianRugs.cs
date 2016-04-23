using System;

class PersianRugs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write(new string('#', i));
            Console.Write('\\');
            if (d + i < n - 1)
            {
                Console.Write(new string(' ', d));
                Console.Write('\\');
                Console.Write(new string('.', (n * 2 + 1 - d * 2 - 2 - (i + 1) * 2)));
                Console.Write('/');
                Console.Write(new string(' ', d));
            }
            else
            {
                Console.Write(new string(' ', (n * 2 - 1 - i * 2)));
            }

            Console.Write('/');
            Console.WriteLine(new string('#', i));
        }

        Console.Write(new string('#', n));
        Console.Write('X');
        Console.WriteLine(new string('#', n));

        for (int i = n - 1; i >= 0; i--)
        {
            Console.Write(new string('#', i));
            Console.Write('/');
            if (d + i < n - 1)
            {
                Console.Write(new string(' ', d));
                Console.Write('/');
                Console.Write(new string('.', (n * 2 + 1 - d * 2 - 2 - (i + 1) * 2)));
                Console.Write('\\');
                Console.Write(new string(' ', d));
            }
            else
            {
                Console.Write(new string(' ', (n * 2 - 1 - i * 2)));
            }

            Console.Write('\\');
            Console.WriteLine(new string('#', i));
        }
    }
}
