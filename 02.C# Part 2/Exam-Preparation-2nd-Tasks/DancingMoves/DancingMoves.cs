using System;
using System.Linq;

class DancingMoves
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        string line = Console.ReadLine();
        long sum = 0;
        int counter = 0;
        int index = 0;
        while (line != "stop")
        {
            string[] command = line.Split(' ');
            int moves = int.Parse(command[0]);
            string direction = command[1];
            int times = int.Parse(command[2]);

            for (int i = 0; i < moves; i++)
            {
                if (direction == "right")
                {
                    index = (index + times) % arr.Length;
                }
                else
                {
                    index = (arr.Length + ((index - times) % arr.Length)) % arr.Length;
                }

                sum += arr[index];
            }

            counter++;
            line = Console.ReadLine();
        }

        decimal output = (decimal)sum / counter;
        Console.WriteLine("{0:F1}", output);
    }
}
