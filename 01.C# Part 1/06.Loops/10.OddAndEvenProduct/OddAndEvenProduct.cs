using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.ReadLine();
        string[] array = Console.ReadLine().Split(' ');

        long oddProduct = 1;
        long evenProduct = 1;

        for (int i = 0; i < array.Length; i++)
        {
            int number = int.Parse(array[i]);
            if (i % 2 == 0)
            {
                evenProduct *= number;
            }
            else
            {
                oddProduct *= number;
            }
        }

        if (oddProduct == evenProduct)
        {
            Console.WriteLine("yes " + oddProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evenProduct, oddProduct);
        }
    }
}