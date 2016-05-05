using System;

class MaximalSequence
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int previousNumber = int.MinValue;
        int currentLength = 1;
        int maxLength = 1;
        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            if (currentNumber == previousNumber)
            {
                currentLength++;
            }
            else
            {
                currentLength = 1;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
            }

            previousNumber = currentNumber;
        }

        Console.WriteLine(maxLength);
    }
}
