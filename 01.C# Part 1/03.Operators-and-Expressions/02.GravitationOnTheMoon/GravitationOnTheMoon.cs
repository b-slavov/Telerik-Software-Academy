using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        Console.Write("Enter weight: ");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Weight on the moon: " + weight * 0.17);
    }
}