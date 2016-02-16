﻿namespace Variations
{
    using System;

    class Variations
    {
        const int N = 3;
        const int K = 2;

        private static readonly string[] set = { "hi", "a", "b" };

        static readonly int[] arr = new int[K];

        static void Main()
        {
            GenerateVariationsWithRepetitions(0);
        }

        static void GenerateVariationsWithRepetitions(int index)
        {
            if (index >= K)
            {
                PrintVariations();
            }
            else
            {
                for (int i = 0; i < N; i++)
                {
                    arr[index] = i;
                    GenerateVariationsWithRepetitions(index + 1);
                }
            }
        }

        static void PrintVariations()
        {
            Console.Write("(" + String.Join(", ", arr) + ") --> ( ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(set[arr[i]] + " ");
            }

            Console.WriteLine(")");
        }
    }
}