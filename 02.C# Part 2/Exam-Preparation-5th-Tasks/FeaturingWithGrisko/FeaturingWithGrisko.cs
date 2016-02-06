﻿using System;

class FeaturingWithGrisko
{
    static void Main()
    {
        var input = Console.ReadLine();
        var inputAsCharArray = input.ToCharArray();
        Array.Sort(inputAsCharArray);
        int count = 0;
        do
        {
            if (IsMatch(inputAsCharArray))
            {
                count++;
            }
        }
        while (!NextPermutation(inputAsCharArray));
        Console.WriteLine(count);
    }

    public static bool IsMatch(char[] word)
    {
        for (int i = 1; i < word.Length; i++)
        {
            if (word[i] == word[i - 1])
            {
                return false;
            }
        }

        return true;
    }

    private static bool NextPermutation(char[] array)
    {
        for (int index = array.Length - 2; index >= 0; index--)
        {
            if (array[index] < array[index + 1])
            {
                int swapWithIndex = array.Length - 1;
                while (array[index] >= array[swapWithIndex])
                {
                    swapWithIndex--;
                }

                var temp = array[index];
                array[index] = array[swapWithIndex];
                array[swapWithIndex] = temp;
                Array.Reverse(array, index + 1, array.Length - index - 1);
                return true;
            }
        }

        return false;
    }
}