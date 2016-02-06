using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();

        Console.WriteLine(new string(str.ToCharArray().Reverse().ToArray()));
    }
}