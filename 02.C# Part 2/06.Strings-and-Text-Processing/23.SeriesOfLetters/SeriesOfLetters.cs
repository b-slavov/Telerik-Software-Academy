﻿using System;
using System.Linq;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter text: ");
        string input = Console.ReadLine();

        input.Distinct().Select(c => c.ToString()).ToList()
            .ForEach(c =>
            {
                while (input.Contains(c + c))
                {
                    input = input.Replace(c + c, c);
                }
            });

        Console.WriteLine(input);
    }
}