using System;
using System.Linq;
using System.Text.RegularExpressions;

class SubstringInText
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string str = Console.ReadLine();
        Console.Write("Enter substring: ");
        string subStr = Console.ReadLine();

        Console.WriteLine("Substring {0} appears {1} times in the text. ", subStr, Regex.Matches(str, subStr).Cast<Match>().Count());
    }
}