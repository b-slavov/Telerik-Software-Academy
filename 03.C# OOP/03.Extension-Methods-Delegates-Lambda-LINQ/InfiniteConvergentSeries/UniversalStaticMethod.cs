namespace InfiniteConvergentSeries
{
    using System;

    public class UniversalStaticMethod
    {
        public static void Main()
        {
            // 1 + 1/2 + 1/4 + 1/8 + 1/16 + … -> 1.99999994039536
            // function - 2^0 + 2^-1 + 2^-2 + 2^-3 ...
            double testOne = CalculateSum(
                2,
                0,
                (x, y) => Math.Pow(x, y),
                x => x,
                y => y - 1);

            // 1 + 1/2! + 1/3! + 1/4! + 1/5! + … -> 1.71828182619849
            double testTwo = CalculateSum(
                1,
                1,
                (x, y) => x / Factorial(y),
                x => x,
                y => y + 1);

            // 1 + 1/2 - 1/4 + 1/8 - 1/16 + … -> 1.3333(3)
            double testThree = CalculateSum(
                2,
                0,
                (x, y) => y % 2 == 0 && y != 0 ? -Math.Pow(x, y) : Math.Pow(x, y),
                x => x,
                y => y - 1);

            Console.WriteLine("Test one -> {0:F2}", testOne);
            Console.WriteLine("Test two -> {0:F2}", testTwo);
            Console.WriteLine("Test three -> {0:F2}", testThree);
        }

        // the method needs two arguments, function to calculate each member of the sequence and how each of the arguments change its value
        public static double CalculateSum(
            double firstArg,
            double secondArg,
            Func<double, double, double> getSum,
            Func<double, double> firstArgBehavior,
            Func<double, double> secondArgBehavior)
        {
            double sum = 0;
            double previousSum;

            do
            {
                previousSum = sum;

                // add to the sum each member of the sequence
                sum += getSum(firstArg, secondArg);

                // the two arguments change their values
                firstArg = firstArgBehavior(firstArg);
                secondArg = secondArgBehavior(secondArg);
            }
            while (Math.Abs(sum - previousSum) > 0.0000001);

            return sum;
        }

        private static double Factorial(double y)
        {
            double result = 1;

            for (int i = 1; i <= y; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
