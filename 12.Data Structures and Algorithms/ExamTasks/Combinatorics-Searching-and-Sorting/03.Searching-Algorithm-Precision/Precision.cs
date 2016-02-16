namespace CombinatoricsSearchingAndSortingAlgorithms
{
    using System;

    class Precision
    {
        static bool Compare(string fraction, int a, int b)
        {
            a *= 10;
            int i;
            for (i = 0; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit < fraction[i] - '0')
                {
                    return false;
                }
                else if (digit > fraction[i] - '0')
                {
                    return true;
                }

                a = a % b * 10;
            }

            return true;
        }

        static int DividePrecision(string fraction, int a, int b)
        {
            a *= 10;
            int i;
            for (i = 0; i < fraction.Length; i++)
            {
                int digit = a / b;
                if (digit != fraction[i] - '0')
                {
                    break;
                }

                a = a % b * 10;
            }

            return i;
        }

        static void Main(string[] args)
        {
            int maxDenominator = int.Parse(Console.ReadLine());
            var fraction = Console.ReadLine().Split('.')[1];

            int bestNominator = 0;
            int bestDenominator = 1;
            int bestPrecision = 0;
            for (int denominator = 1; denominator <= maxDenominator; denominator++)
            {
                int left = 0;
                int right = denominator;

                while (left < right)
                {
                    int middle = (left + right) / 2;
                    if (Compare(fraction, middle, denominator))
                    {
                        right = middle;
                    }
                    else
                    {
                        left = middle + 1;
                    }
                }

                int precision = DividePrecision(fraction, left - 1, denominator);
                if (precision > bestPrecision)
                {
                    bestDenominator = denominator;
                    bestNominator = left - 1;
                    bestPrecision = precision;
                }

                precision = DividePrecision(fraction, left, denominator);
                if (precision > bestPrecision)
                {
                    bestDenominator = denominator;
                    bestNominator = left;
                    bestPrecision = precision;
                }
            }

            Console.WriteLine("{0}/{1}", bestNominator, bestDenominator);
            Console.WriteLine(bestPrecision + 1);
        }
    }
}