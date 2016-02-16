namespace MessagesInABottle
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MessagesInABottle
    {
        static List<KeyValuePair<char, string>> chiphers = new List<KeyValuePair<char, string>>();

        static string message;

        static void Main()
        {
            message = Console.ReadLine();
            string chipher = Console.ReadLine();

            char key = char.MinValue;
            var value = new StringBuilder();
            for (int i = 0; i < chipher.Length; i++)
            {
                if (chipher[i] >= 'A' && chipher[i] <= 'Z')
                {
                    if (key != char.MinValue)
                    {
                        chiphers.Add(new KeyValuePair<char, string>(key, value.ToString()));
                        value.Clear();
                    }

                    key = chipher[i];
                }
                else
                {
                    value.Append(chipher[i]);
                }
            }

            if (key != char.MinValue)
            {
                chiphers.Add(new KeyValuePair<char, string>(key, value.ToString()));
                value.Clear();
            }

            Solve(0, new StringBuilder());
            Console.WriteLine(solutions.Count);
            solutions.Sort();
            foreach (var solution in solutions)
            {
                Console.WriteLine(solution);
            }
        }

        static List<string> solutions = new List<string>();

        static void Solve(int messageIndex, StringBuilder sb)
        {
            if (messageIndex == message.Length)
            {
                solutions.Add(sb.ToString());
                return;
            }
            
            foreach (var chiper in chiphers)
            {
                if (message.Substring(messageIndex).StartsWith(chiper.Value))
                {
                    sb.Append(chiper.Key);
                    Solve(messageIndex + chiper.Value.Length, sb);
                    sb.Length--;
                }
            }
        }
    }
}