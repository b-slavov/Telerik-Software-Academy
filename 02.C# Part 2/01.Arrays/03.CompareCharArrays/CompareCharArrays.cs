using System;

class CompareCharArrays
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();

        int loopLength = Math.Min(firstInput.Length, secondInput.Length);

        for (int i = 0; i < loopLength; i++)
        {
            if (firstInput[i] > secondInput[i] || i == loopLength - 1 && firstInput.Length > secondInput.Length)
            {
                Console.WriteLine(">");
                return;
            }
            else if (firstInput[i] < secondInput[i] || i == loopLength - 1 && firstInput.Length < secondInput.Length)
            {
                Console.WriteLine("<");
                return;
            }
            else if (i == loopLength - 1 && firstInput.Length == secondInput.Length)
            {
                Console.WriteLine("=");
            }
        }
    }
}
