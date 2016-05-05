using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        char[] firstCharArray = firstInput.ToCharArray();
        char[] secondCharArray = secondInput.ToCharArray();

        if (firstCharArray.Length > secondCharArray.Length)
        {
            Console.WriteLine(">");
        }
        else if (firstCharArray.Length < secondCharArray.Length)
        {
            Console.WriteLine("<");
        }
        else
        {
            for (int i = 0; i < firstCharArray.Length; i++)
            {
                if (firstCharArray[i] > secondCharArray[i])
                {
                    Console.WriteLine(">");
                    break;
                }
                else if(firstCharArray[i] < secondCharArray[i])
                {
                    Console.WriteLine("<");
                    break;
                }
                else if (i == firstCharArray.Length - 1 && firstCharArray[i] == secondCharArray[i])
                {
                    Console.WriteLine("=");
                }
            }
        }
    }
}
