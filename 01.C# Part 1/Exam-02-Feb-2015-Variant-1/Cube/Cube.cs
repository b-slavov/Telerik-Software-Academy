using System;

class Cube
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.Write(new string(' ', n - 1));
        Console.WriteLine(new string(':', n));

        Console.Write(new string(' ', n - 2));
        Console.Write(':');
        Console.Write(new string ('/', n - 2));
        Console.WriteLine(new string(':', 2));
        
        for (int i = 3; i < n; i++)
        {
            Console.Write(new string(' ', n - i));
            Console.Write(':');
            Console.Write(new string('/', n - 2));
            Console.Write(':');
            Console.Write(new string ('X', i - 2));
            Console.WriteLine(':');
        }

        Console.Write(new string(':', n));
        Console.Write(new string('X', n - 2));
        Console.WriteLine(':');

        for (int i = n - 3; i > 0; i--)
        {
            Console.Write(':');
            Console.Write(new string(' ', n - 2));
            Console.Write(':');
            Console.Write(new string('X', i));
            Console.WriteLine(':');
        }

        Console.Write(':');
        Console.Write(new string(' ', n - 2));
        Console.WriteLine(new string(':', 2));
        Console.WriteLine(new string(':', n));
    }
}
