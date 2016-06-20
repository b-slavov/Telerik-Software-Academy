namespace LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StringWithMaxLength
    {
        private static int maxLength;

        public static void Main()
        {
            string[] arrayOfStrings = { "Eminem", "DMX", "2Pac", "Spens", "Rick Ross" };
            maxLength = arrayOfStrings[0].Length;
            var result = GetLongest(arrayOfStrings);
            Console.WriteLine("The longest string in {0} is {1}", string.Join(", ", arrayOfStrings), result.OrderByDescending(x => x.Length).First());
        }

        public static IEnumerable<string> GetLongest(string[] arr)
        {
            // LINQ query
            // var longestString =
            //    from str in arr
            //    orderby str.Length descending
            //    select str;

            // or with separated method
            var longestString =
                from str in arr
                where CheckMax(str)
                select str;

            return longestString;
        }

        public static bool CheckMax(string item)
        {
            if (item.Length >= maxLength)
            {
                maxLength = item.Length;
                return true;
            }

            return false;
        }
    }
}
