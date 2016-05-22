using System;
using System.Collections.Generic;

class CorrectBrackets
{
    static void Main()
    {
        string input = Console.ReadLine();
        Stack<char> stack = new Stack<char>();

        foreach (char ch in input)
        {
            try
            {
                if (ch == '(')
                {
                    stack.Push('.');
                }
                else if (ch == ')')
                {
                    stack.Pop();
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Incorrect");
                return;
            }
        }

        if (stack.Count == 0)
        {
            Console.WriteLine("Correct");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}
