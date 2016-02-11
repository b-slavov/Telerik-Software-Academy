namespace QualityMethods
{
    using System;

    public class Methods
    {
        internal static double CalculateTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("All sides must be greater than 0!");
            }

            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentOutOfRangeException("These sides cannot form a triangle!");
            }

            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            return area;
        }

        internal static string DigitToString(int digit)
        {
            switch (digit)
            {
                case 0: return "Zero";
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                default: throw new ArgumentOutOfRangeException("Use digits from 0 to 9!");
            }
        }

        internal static int FindMaximalElement(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("There are no input elements!");
            }

            int maxElement = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }

            return maxElement;
        }

        internal static void NumberWithPrecisionTwoDigitsAfterTheDecimalPoint(double number)
        {
            Console.WriteLine("{0:F2}", number);
        }

        internal static void NumberAsPercentage(double number)
        {
            Console.WriteLine("{0:P0}", number);
        }

        internal static void NumberEightSignsRightAligned(double number)
        {
            Console.WriteLine("{0,8}", number);
        }

        internal static double CalculateDistance(double x1, double x2, double y1, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        internal static bool IsLineHorizontal(double x1, double x2)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(x1 - x2) < AcceptableDifference;
        }

        internal static bool IsLineVertical(double y1, double y2)
        {
            const double AcceptableDifference = 0.000001;
            return Math.Abs(y1 - y2) < AcceptableDifference;
        }
    }
}