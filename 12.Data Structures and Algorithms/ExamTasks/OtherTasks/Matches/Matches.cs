namespace Matches
{
    using System;
    using System.Collections.Generic;

    public class Matches
    {
        public class Hash
        {
            private const ulong BASE1 = 127;
            private const ulong BASE2 = 131;
            private const ulong MOD = 1000000033;

            private static ulong[] powers1;
            private static ulong[] powers2;

            public static void ComputePowers(int n)
            {
                powers1 = new ulong[n + 1];
                powers2 = new ulong[n + 1];
                powers1[0] = 1;
                powers2[0] = 1;

                for (int i = 0; i < n; i++)
                {
                    powers1[i + 1] = powers1[i] * BASE1 % MOD;
                    powers2[i + 1] = powers2[i] * BASE2 % MOD;
                }
            }

            public ulong Value1 { get; private set; }
            public ulong Value2 { get; private set; }

            public Hash(string str)
            {
                this.Value1 = 0;

                foreach (char c in str)
                {
                    this.Add(c);
                }
            }

            public void Add(char c)
            {
                this.Value1 = (this.Value1 * BASE1 + c) % MOD;
                this.Value2 = (this.Value2 * BASE2 + c) % MOD;
            }

            public void Remove(char c, int n)
            {
                this.Value1 = (MOD + this.Value1 - powers1[n] * c % MOD) % MOD;
                this.Value2 = (MOD + this.Value2 - powers2[n] * c % MOD) % MOD;
            }
        }

        static void Main()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            Console.WriteLine(Solve(firstString, secondString));
        }

        private static int Solve(string firstString, string secondString)
        {
            int left = 0;
            int right = Math.Min(firstString.Length, secondString.Length);

            Hash.ComputePowers(Math.Min(firstString.Length, secondString.Length));

            while (left < right)
            {
                int middle = (left + right) / 2;

                bool hasFoundMatch = Check(firstString, secondString, middle);

                if (hasFoundMatch)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            return right - 1;
        }

        private static bool Check(string firstString, string secondString, int length)
        {
            var firstHash = new Hash(firstString.Substring(0, length));
            var hashes1 = new HashSet<ulong>();
            var hashes2 = new HashSet<ulong>();
            hashes1.Add(firstHash.Value1);
            hashes2.Add(firstHash.Value2);

            for (int i = 0; i < firstString.Length - length; i++)
            {
                firstHash.Add(firstString[length + i]);
                firstHash.Remove(firstString[i], length);

                hashes1.Add(firstHash.Value1);
                hashes2.Add(firstHash.Value2);
            }

            var secondHash = new Hash(secondString.Substring(0, length));
            if (hashes1.Contains(secondHash.Value1) && hashes2.Contains(secondHash.Value2))
            {
                return true;
            }

            for (int i = 0; i < secondString.Length - length; i++)
            {
                secondHash.Add(secondString[length + i]);
                secondHash.Remove(secondString[i], length);
                if (hashes1.Contains(secondHash.Value1) && hashes2.Contains(secondHash.Value2))
                {
                    return true;
                }
            }

            return false;
        }
    }
}