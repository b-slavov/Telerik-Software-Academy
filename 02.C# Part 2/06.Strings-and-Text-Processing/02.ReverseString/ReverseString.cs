using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();

        Console.WriteLine(input.ToCharArray().Reverse().ToArray());
    }
}
