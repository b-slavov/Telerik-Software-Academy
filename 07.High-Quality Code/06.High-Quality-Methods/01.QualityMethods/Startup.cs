namespace QualityMethods
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine(Methods.CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.DigitToString(5));

            Console.WriteLine(Methods.FindMaximalElement(5, -1, 3, 2, 14, 2, 3));

            Methods.NumberWithPrecisionTwoDigitsAfterTheDecimalPoint(1.3);
            Methods.NumberAsPercentage(0.75);
            Methods.NumberEightSignsRightAligned(2.30);

            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5));
            Console.WriteLine("Is the line horizontal? " + Methods.IsLineHorizontal(3, -1));
            Console.WriteLine("Is the line vertical? " + Methods.IsLineVertical(3, 2.5));

            Student peter = new Student("Peter", "Ivanov", new DateTime(1992, 3, 17), "From Sofia");
            Student stella = new Student("Stella", "Markova", new DateTime(1993, 11, 3), "From Vidin, gamer, high results");

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}