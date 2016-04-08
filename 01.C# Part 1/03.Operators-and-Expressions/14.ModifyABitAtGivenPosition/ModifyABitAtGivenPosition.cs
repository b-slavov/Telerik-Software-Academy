using System;

class ModifyABit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        byte position = byte.Parse(Console.ReadLine());
        byte value = byte.Parse(Console.ReadLine());

        if (value == 0)
        {
            ulong mask = (ulong)~(1 << position);
            ulong result = number & mask;
            Console.WriteLine(result);
        }
        else
        {
            ulong mask = (ulong)1 << position;
            ulong result = number | mask;
            Console.WriteLine(result);
        }
    }
}
