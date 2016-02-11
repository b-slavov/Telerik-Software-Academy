namespace CSharp2ExamTask4
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class BrackestsAgain
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            var result = new StringBuilder();
            var methodCalls = new List<string>();
            bool inMethod = false;

            for (int i = 0; i < numberOfLines; i++)
            {
                string currentLine = Console.ReadLine();

                if (currentLine.Contains("static") && inMethod)
                {
                    inMethod = false;

                    if (methodCalls.Count > 0)
                    {
                        result.AppendLine(string.Join(", ", methodCalls));
                    }
                    else
                    {
                        result.AppendLine("None");
                    }

                    methodCalls.Clear();
                }

                if (currentLine.Contains("static") && !inMethod)
                {
                    inMethod = true;
                    string methodDeclaration = GetMethodDeclaration(currentLine);
                    result.Append(methodDeclaration);
                    result.Append(" -> ");
                    continue;
                }

                if (inMethod)
                {
                    GetMethodCall(currentLine, methodCalls);
                }
            }

            if (methodCalls.Count > 0)
            {
                result.AppendLine(string.Join(", ", methodCalls));
            }
            else
            {
                result.AppendLine("None");
            }

            Console.Write(result);
        }

        static string GetMethodDeclaration(string currentLine)
        {
            int startIndex = 0;
            int endIndex = 0;

            startIndex = currentLine.IndexOf(currentLine.FirstOrDefault(c => char.IsUpper(c)));
            endIndex = currentLine.IndexOf("(");

            return currentLine.Substring(startIndex, endIndex - startIndex);
        }

        static void GetMethodCall(string currentLine, List<string> methodCalls)
        {
            int startIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < currentLine.Length; i++)
            {
                char letter = currentLine[i];
                if (char.IsUpper(letter))
                {
                    startIndex = i;
                    endIndex = i + 1;

                    while (char.IsLetterOrDigit(currentLine[endIndex]))
                    {
                        endIndex++;
                        i++;
                    }

                    if (currentLine[endIndex] == '(')
                    {
                        methodCalls.Add(currentLine.Substring(startIndex, endIndex - startIndex));
                    }
                }
            }            
        }
    }
}