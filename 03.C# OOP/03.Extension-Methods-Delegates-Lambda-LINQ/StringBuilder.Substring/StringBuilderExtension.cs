namespace StringBuilder.Substring
{
    using System.Text;

    public static class StringBuilderExtension
    {
        // The StringBuilder throws an exception if the index is invalid, so there is no need to check the index
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            var result = new StringBuilder();

            for (int i = index; length > 0; i++, length--)
            {
                result.Append(input[i]);
            }

            return result;
        }

        public static StringBuilder Substring(this StringBuilder input, int index)
        {
            var result = new StringBuilder();

            for (int i = index; i < input.Length; i++)
            {
                result.Append(input[i]);
            }

            return result;
        }
    }
}
