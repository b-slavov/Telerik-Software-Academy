using System;

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter arrays lenght: ");
        int n = int.Parse(Console.ReadLine());
        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Array1[{0}]: ", i);
            firstArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("Array2[{0}]: ", i);
            secondArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] > secondArray[i])
            {
                Console.WriteLine("{0} > {1}", firstArray[i], secondArray[i]);
            }
            else if (firstArray[i] < secondArray[i])
            {
                Console.WriteLine("{0} < {1}", firstArray[i], secondArray[i]);
            }
            else
            {
                Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
            }
        }
    }
}