using System;

class MatrixOfNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = 0, counter = 0; j < n; j++, counter++)
            {
                Console.Write(j != n - 1 ? i + counter + " " : i + counter + "\n");
            }
        }
    }
}