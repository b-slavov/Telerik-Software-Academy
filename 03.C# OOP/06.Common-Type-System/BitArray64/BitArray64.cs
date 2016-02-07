namespace BitArray64
{
    using System;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong value;

        private int[] bitArray;

        public BitArray64(ulong value = 0)
        {
            this.Value = value;
        }

        public ulong Value
        {
            get
            {
                return this.GetValue(this.bitArray);
            }

            set
            {
                this.value = value;
                this.bitArray = this.GetBits(value);
            }
        }

        public int this[int index]
        {
            get
            {
                return this.bitArray[index];
            }

            set
            {
                if (value != 1 && value != 0)
                {
                    throw new ArgumentException("Value can be 1 or 0");
                }

                this.bitArray[index] = value;
                this.value = this.GetValue(this.bitArray);
            }
        }

        public static bool operator ==(BitArray64 firstArr, BitArray64 secondArr)
        {
            return BitArray64.Equals(firstArr, secondArr);
        }

        public static bool operator !=(BitArray64 firstArr, BitArray64 secondArr)
        {
            return !BitArray64.Equals(firstArr, secondArr);
        }
        
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this.bitArray[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public override string ToString()
        {
            return string.Join(string.Empty, this.bitArray);
        }

        public override bool Equals(object obj)
        {
            BitArray64 array = obj as BitArray64;

            if ((object)array == null)
            {
                return false;
            }

            return BitArray64.Equals(this.value, array.value);
        }

        public override int GetHashCode()
        {
            return this.value.GetHashCode() ^ this.bitArray.GetHashCode();
        }

        // Convert value <-> bits
        private int[] GetBits(ulong input)
        {
            int[] result = new int[64];
            int bitIndex = 63;

            while (input != 0)
            {
                result[bitIndex] = (int)(input % 2);

                bitIndex--;
                input >>= 1;
            }

            return result;
        }

        private ulong GetValue(int[] bits)
        {
            ulong result = 0;

            for (int i = 63; i >= 0; i--)
            {
                if (bits[i] == 1)
                {
                    result += (ulong)Math.Pow(2, bits.Length - 1 - i);
                }
            }

            return result;
        }
    }
}