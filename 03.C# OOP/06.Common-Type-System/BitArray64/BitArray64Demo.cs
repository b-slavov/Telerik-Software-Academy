namespace BitArray64
{
    using System;

    public class BitArrayDemo
    {
        public static void Main()
        {
            var testArr = new BitArray64(16);
            Console.WriteLine("Bits: {0}", testArr);
            Console.WriteLine("Value: {0}", testArr.Value);
            Console.WriteLine();

            // change some index -> value changes too
            testArr[58] = 1;
            Console.WriteLine("Bits: {0}", testArr);
            Console.WriteLine("Value: {0}\n", testArr.Value);

            // test foreach
            var maxArr = new BitArray64(ulong.MaxValue);

            Console.Write("Bits: ");
            foreach (int bit in maxArr)
            {
                Console.Write(bit);
            }

            Console.WriteLine();

            Console.WriteLine("Value: {0}\n", maxArr.Value);

            // test Equals, ==
            var newArr = new BitArray64(48);

            Console.WriteLine(testArr.Equals(newArr)); // 48 == 48 -> true
            Console.WriteLine(newArr != testArr); // 48 != 48 -> false
        }
    }
}