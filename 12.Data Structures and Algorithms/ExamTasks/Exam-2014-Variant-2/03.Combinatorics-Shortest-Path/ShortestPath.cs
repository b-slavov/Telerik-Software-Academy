namespace Combinatorics
{
    using System;
    using System.Collections.Generic;

    public class ShortestPath
    {
        private static char[] map;

        private static SortedSet<string> paths = new SortedSet<string>();

        public static void Find(int index)
        {
            if (index == map.Length)
            {
                paths.Add(new string(map));
            }
            else if (map[index] != '*')
            {
                Find(index + 1);
            }
            else
            {
                map[index] = 'S';
                Find(index + 1);
                map[index] = 'R';
                Find(index + 1);
                map[index] = 'L';
                Find(index + 1);
                map[index] = '*';
            }
        }

        public static void Main()
        {
            map = Console.ReadLine().ToCharArray();

            Find(0);

            Console.WriteLine(paths.Count);
            foreach (var path in paths)
            {
                Console.WriteLine(path);
            }
        }
    }
}