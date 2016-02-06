﻿using System;
using System.Text;

class TRES4Numbers
{
    static void Main()
    {
        var numeralSystem = 9;
        var digits = new[] { "LON+", "VK-", "*ACAD", "^MIM", "ERIK|", "SEY&", "EMY>>", "/TEL", "<<DON" };
        ulong numberInDecimal = ulong.Parse(Console.ReadLine());
        var result = new StringBuilder();
        if (numberInDecimal == 0)
        {
            Console.WriteLine(digits[0]);
        }
        else
        {
            while (numberInDecimal > 0)
            {
                int digitIn9th = (int)(numberInDecimal % (ulong)numeralSystem);
                result.Insert(0, digits[digitIn9th]);
                numberInDecimal /= (ulong)numeralSystem;
            }
        }

        Console.WriteLine(result.ToString());
    }
}