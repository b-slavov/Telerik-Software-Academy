using System;

class ComparingFloats
{
    static void Main()
    {
        double numberA = 5.3;
        double numberB = 6.01;
        bool equal = Math.Abs(numberA - numberB) < 0.000001;
        Console.WriteLine("{0} == {1} -> {2}", numberA, numberB, equal);

        numberA = 5.00000001;
        numberB = 5.00000003;
        equal = Math.Abs(numberA - numberB) < 0.000001;
        Console.WriteLine("{0} == {1} -> {2}", numberA, numberB, equal);

        numberA = 5.00000005;
        numberB = 5.00000001;
        equal = Math.Abs(numberA - numberB) < 0.000001;
        Console.WriteLine("{0} == {1} -> {2}", numberA, numberB, equal);

        numberA = -0.0000007;
        numberB = 0.00000007;
        equal = Math.Abs(numberA - numberB) < 0.000001;
        Console.WriteLine("{0} == {1} -> {2}", numberA, numberB, equal);

        numberA = -4.999999;
        numberB = -4.999998;
        equal = Math.Abs(numberA - numberB) < 0.000001;
        Console.WriteLine("{0} == {1} -> {2}", numberA, numberB, equal);

        numberA = 4.999999;
        numberB = 4.999998;
        equal = Math.Abs(numberA - numberB) < 0.000001;
        Console.WriteLine("{0} == {1} -> {2}", numberA, numberB, equal);
    }
}