namespace Dealership.Models
{
    using System;

    public static class ExtendetValidator
    {
        public static void ValidateStringLength(string text, int min, int max, string message)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new IndexOutOfRangeException(message);
            }
        }

        public static void ValidateAddVehicle(string text, int min, int max, string message)
        {
            if (text.Length < min || max < text.Length)
            {
                throw new IndexOutOfRangeException(message);
            }
        }
    }
}
