using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("N = ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayOfNumbers = new int[n];
        for (int i = 0; i < arrayOfNumbers.Length; i++)
        {
            Console.Write("Element[{0}] = ", i + 1);
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());

        Array.Sort(arrayOfNumbers);
        int searchedNumber = Array.BinarySearch(arrayOfNumbers, k);

        if (searchedNumber < -1)
        {
            Console.WriteLine("The largest number lower than or equal to {0} is {1}", k, arrayOfNumbers[~searchedNumber - 1]);
        }
        else if (~searchedNumber == 0)
        {
            Console.WriteLine("No such number");
        }
        else
        {
            Console.WriteLine("The largest number lower than or equal to {0} is {1}", k, arrayOfNumbers[searchedNumber]);
        }
    }
}