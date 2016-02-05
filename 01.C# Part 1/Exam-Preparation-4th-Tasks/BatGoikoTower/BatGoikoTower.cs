using System;

class BatGoikoTower
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int dash = 1;
        int dashIndex = 2;

        for (int i = 0; i <= n - 1; i++)
        {
            Console.Write(new string('.', n - i - 1));
            Console.Write('/');

            if (i == 0)
            {
                Console.Write('\\');
                Console.WriteLine(new string('.', n - i - 1));
            }
            else if (i == dash)
            {
                Console.Write(new string('-', i * 2));
                dash += dashIndex;
                dashIndex++;
                Console.Write('\\');
                Console.WriteLine(new string('.', n - i - 1));
            }
            else
            {
                Console.Write(new string('.', i * 2));
                Console.Write('\\');
                Console.WriteLine(new string('.', n - i - 1));
            }
        }
    }
}