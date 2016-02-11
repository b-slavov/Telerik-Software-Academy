namespace CSharp1ExamTask2
{
    using System;
    using System.Numerics;

    class TextToNumber
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            BigInteger result = 0;

            foreach (char symbol in text)
            {
                if (symbol == '@')
                {
                    break;
                }
                if (char.IsUpper(symbol))
                {
                    result += (symbol - 65);
                }
                if (char.IsLower(symbol))
                {
                    result += (symbol - 97);
                }
                if (char.IsDigit(symbol))
                {
                    result *= (int)(symbol - 48);
                }
                if ((symbol) >= 32 && (symbol) <= 47 ||
                    (symbol) >= 58 && (symbol) <= 63 ||
                    (symbol) >= 91 && (symbol) <= 96 ||
                    (symbol) >= 123 && (symbol) <= 126)
                {
                    result %= number;
                }
            }

            Console.WriteLine(result);
        }
    }
}