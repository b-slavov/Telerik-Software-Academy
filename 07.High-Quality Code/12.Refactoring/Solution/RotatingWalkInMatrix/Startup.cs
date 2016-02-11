namespace TraverseMatrix
{
    using System;

    public class MainProgram
    {
        public static void Main()
        {
            MatrixGenerator matrix = new MatrixGenerator(7);
            Console.WriteLine(matrix);
        }
    }
}