namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T Min<T>(this IEnumerable<T> elements)
            where T : IComparable<T>
        {
            // FirstOrDefault() will return default(T) if the enumerable is empty
            T minValue = elements.FirstOrDefault();

            foreach (T element in elements)
            {
                if (minValue.CompareTo(element) > 0)
                {
                    minValue = element;
                }
            }

            return minValue;
        }

        public static T Max<T>(this IEnumerable<T> elements)
            where T : IComparable<T>
        {
            // FirstOrDefault() will return default(T) if the enumerable is empty
            T maxValue = elements.FirstOrDefault();

            foreach (T element in elements)
            {
                if (maxValue.CompareTo(element) < 0)
                {
                    maxValue = element;
                }
            }

            return maxValue;
        }

        public static dynamic Sum<T>(this IEnumerable<T> elements)
        {
            dynamic sum = 0;

            foreach (T element in elements)
            {
                sum += element;
            }

            return sum;
        }

        public static dynamic Product<T>(this IEnumerable<T> elements)
        {
            dynamic product = 1;

            foreach (T element in elements)
            {
                product *= element;
            }

            return product;
        }

        public static double Average<T>(this IEnumerable<T> elements)
        {
            return (dynamic)elements.Sum() / (double)elements.Count();
        }
    }
}