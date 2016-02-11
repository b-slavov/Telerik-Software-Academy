namespace CSharp2ExamTask2
{
    using System;
    using System.Numerics;
    using System.Linq;

    class SumOfDifferences
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();

            BigInteger sum = 0;
            BigInteger output = 0;
            for (int i = 1; i < input.Length; i++)
            {
                BigInteger biggerElement = 0;
                BigInteger smallerElement = 0;
                if (input[i] >= input[i - 1])
                {
                    biggerElement = input[i];
                    smallerElement = input[i - 1];
                }

                else
                {
                    biggerElement = input[i - 1];
                    smallerElement = input[i];
                }

                sum = biggerElement - smallerElement;
                if (sum % 2 != 0)
                {
                    output += sum;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine(output);
        }
    }
}