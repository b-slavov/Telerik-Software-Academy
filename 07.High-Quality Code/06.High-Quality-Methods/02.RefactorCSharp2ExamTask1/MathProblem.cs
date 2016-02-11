namespace CSharp2ExamTask1
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class MathProblem
    {
        static void Main()
        {
            var numeralSystem = 19;
            var alphabet = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s" };
            var input = Console.ReadLine();
            string[] words = input.Split(' ');
            long decimalRepresentation = 0;
            long output = 0;
            foreach (var word in words)
            {
                for (int i = 0, j = word.Length - 1; i < word.Length; i++, j--)
                {
                    var digitIn19th = word.Substring(i, 1);
                    var decimalValue = alphabet.IndexOf(digitIn19th);
                    decimalRepresentation += decimalValue * PowerOfNineteen(j);
                }

                output += decimalRepresentation;
                decimalRepresentation = 0;
            }

            var result = new StringBuilder();
            var numberInDecimal = output;
            if (numberInDecimal == 0)
            {
                Console.WriteLine(numberInDecimal + " = " + output);
            }
            else
            {
                while (numberInDecimal > 0)
                {
                    int digitIn19th = (int)(numberInDecimal % numeralSystem);
                    result.Insert(0, alphabet[digitIn19th]);
                    numberInDecimal /= numeralSystem;
                }

                Console.WriteLine(result + " = " + output);
            }
        }

        public static long PowerOfNineteen(int power)
        {
            long result = 1;

            for (int i = 0; i < power; i++)
            {
                result *= 19;
            }

            return result;
        }
    }
}