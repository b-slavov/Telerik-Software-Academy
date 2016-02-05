using System;

class NeuronMapping
{
    static void Main()
    {
        while (true)
        {
            long line = long.Parse(Console.ReadLine());
            if (line == -1)
            {
                break;
            }

            int mostLeftIndex = -1;
            int mostRightIndex = -1;
            for (int i = 0; i < 32; i++)
            {
                long mask = 1 << i;
                long nAndMask = line & mask;
                long bit = nAndMask >> i;
                if (bit == 1)
                {
                    if (mostRightIndex == -1)
                    {
                        mostRightIndex = i;
                    }
                    mostLeftIndex = i;
                }
            }

            if (mostLeftIndex == -1)
            {
                Console.WriteLine(0);
                continue;
            }

            long result = 0;
            for (int i = mostRightIndex; i < mostLeftIndex; i++)
            {
                long mask = 1 << i;
                long nAndMask = line & mask;
                long bit = nAndMask >> i;
                if (bit == 0)
                {
                    result = result | mask;
                }
            }

            Console.WriteLine(result);
        }
    }
}