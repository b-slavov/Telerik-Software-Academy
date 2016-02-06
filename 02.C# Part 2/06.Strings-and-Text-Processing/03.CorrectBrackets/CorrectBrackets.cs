using System;
using System.Collections.Generic;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter expression: ");
        string str = Console.ReadLine();
        Stack<char> stack = new Stack<char>();

        foreach (char ch in str)
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
                Console.WriteLine("Incorrect!");
                return;
            }
        }

        if (stack.Count == 0)
        {
            Console.WriteLine("Correct!");
        }
        else
        {
            Console.WriteLine("Incorrect");
        }
    }
}