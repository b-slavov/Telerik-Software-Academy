using System;
using System.Text;

class SoupScript
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var result = new StringBuilder();
        int curlyBracketsCounter = 0;
        for (int i = 0; i < n; i++)
        {
            string text = Console.ReadLine().Trim();
            if (text == string.Empty)
            {
                continue;
            }

            if (curlyBracketsCounter > 0)
            {
                result.Append(new string(' ', curlyBracketsCounter * 4));
            }

            if (text[0] == '/' && text[1] == '/')
            {
                result.AppendLine(text);
                continue;
            }

            string[] line = text.Split(new string[] { "//" }, StringSplitOptions.None);
            string[] code = line[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (line.Length > 1)
            {
                string comment = "//" + line[1];
                result.AppendLine(comment);
                result.Append(new string(' ', curlyBracketsCounter * 4));
            }

            string codeWOEmptyEnties = string.Join(" ", code);

            for (int j = 0; j < codeWOEmptyEnties.Length; j++)
            {
                if (codeWOEmptyEnties[j] == '{')
                {
                    curlyBracketsCounter++;
                }

                if (codeWOEmptyEnties[j] == '}')
                {
                    curlyBracketsCounter--;
                }

                if (codeWOEmptyEnties[j] == '(' && codeWOEmptyEnties[j + 1] == ' ')
                {
                    codeWOEmptyEnties = codeWOEmptyEnties.Remove(j + 1, 1);
                }

                if (codeWOEmptyEnties[j] == '!' && codeWOEmptyEnties[j + 1] == ' ')
                {
                    codeWOEmptyEnties = codeWOEmptyEnties.Remove(j + 1, 1);
                }

                if (codeWOEmptyEnties[j] == '.' && codeWOEmptyEnties[j + 1] == ' ')
                {
                    codeWOEmptyEnties = codeWOEmptyEnties.Remove(j + 1, 1);
                }

                if (codeWOEmptyEnties[j] == ')' && codeWOEmptyEnties[j + 1] == '{')
                {
                    codeWOEmptyEnties = codeWOEmptyEnties.Insert(j + 1, " ");
                }

                if (codeWOEmptyEnties[j] == ')' && codeWOEmptyEnties[j - 1] == ' ')
                {
                    codeWOEmptyEnties = codeWOEmptyEnties.Remove(j - 1, 1);
                }

                if (codeWOEmptyEnties[j] == '(' && codeWOEmptyEnties[j - 1] == ' ')
                {
                    codeWOEmptyEnties = codeWOEmptyEnties.Remove(j - 1, 1);
                }

                if (codeWOEmptyEnties[j] == '.' && codeWOEmptyEnties[j - 1] == ' ')
                {
                    codeWOEmptyEnties = codeWOEmptyEnties.Remove(j - 1, 1);
                }

                if (codeWOEmptyEnties[j] == ';' && codeWOEmptyEnties[j - 1] == ' ')
                {
                    codeWOEmptyEnties = codeWOEmptyEnties.Remove(j - 1, 1);
                }
            }

            result.AppendLine(codeWOEmptyEnties);
        }

        Console.WriteLine(result);
    }
}
