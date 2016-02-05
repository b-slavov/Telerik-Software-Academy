using System;

class FloatOrDouble
{
    static void Main()
    {
        double firstVariable = 34.567839023;
        float secondVariable = 12.345F;
        double thirdVariable = 8923.1234857;
        float fourthVariable = 3456.091F;

        Console.WriteLine("Float variables are: {0} and {1}", secondVariable, fourthVariable);
        Console.WriteLine("Double variables are: {0} and {1}", firstVariable, thirdVariable);
    }
}