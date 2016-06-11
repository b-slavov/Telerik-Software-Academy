namespace DefiningClassesPartTwo.Matrix
{
    using System;

    public class MatrixDemo
    {
        public static void Main()
        {
            Matrix<int> testOne = new Matrix<int>(2, 2);
            Matrix<int> testTwo = new Matrix<int>(2, 2);

            testOne[0, 0] = 1;
            testOne[0, 1] = 1;
            testOne[1, 0] = 1;
            testOne[1, 1] = 1;

            testTwo[0, 0] = 1;
            testTwo[0, 1] = 2;
            testTwo[1, 0] = 3;
            testTwo[1, 1] = 4;

            if (testOne)
            {
                Console.WriteLine("test one is a non-zero matrix\n");
            }
            else
            {
                Console.WriteLine("test one is a zero matrix\n");
            }

            // Matrix<int> sum = testOne + testTwo;
            // Matrix<int> subtract = testOne - testTwo;
            Matrix<int> product = testOne * testTwo;

            Console.WriteLine("Product:\n{0}", product);
        }
    }
}
