using System;

class CompareCharArrays
{
    static void Main()
    {
        char[] firstArray;
        char[] secondArray;

        Console.Write("Enter first array lenght: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter second array lenght: ");
        int m = int.Parse(Console.ReadLine());

        firstArray = new char[n];
        secondArray = new char[m];

        if (n == m)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("charArray1[{0}] = ", i);
                firstArray[i] = Convert.ToChar(Console.ReadLine());
            }

            for (int j = 0; j < m; j++)
            {
                Console.Write("charArray2[{0}] = ", j);
                secondArray[j] = Convert.ToChar(Console.ReadLine());
            }

            for (int k = 0; k < n; k++)
            {
                if (firstArray[k] == secondArray[k])
                {
                    Console.WriteLine("Chars[{0}] are equal.", k);
                }
                else
                {
                    Console.WriteLine("Chars[{0}] are NOT equal.", k);
                }
            }
        }
        else
        {
            Console.WriteLine("Arrays are NOT with equal lenght.");
        }
    }
}