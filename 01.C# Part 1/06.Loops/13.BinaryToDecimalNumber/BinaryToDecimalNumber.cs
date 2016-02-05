using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("binary: ");
        string binaryNumber = Console.ReadLine();

        long decimalNumber = 0;
        int power = 1;

        for (int i = binaryNumber.Length - 1; i >= 0; i--)
        {
            int num = binaryNumber[i] - 48;
            decimalNumber += num * power;
            power *= 2;
        }

        Console.WriteLine("decimal: " + decimalNumber);
    }
}