using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("For integer choose 1");
        Console.WriteLine("For double choose 2");
        Console.WriteLine("For string choose 3");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.Write("Enter an integer variable: ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + (i + 1));
                break;
            case "2":
                Console.Write("Enter a double variable: ");
                double d = double.Parse(Console.ReadLine());
                Console.WriteLine("Result: " + (d + 1));
                break;
            case "3":
                Console.Write("Enter a string: ");
                string s = Console.ReadLine();
                Console.WriteLine("Result: " + s + "*");
                break;
            default:
                Console.WriteLine("Not a valid input!");
                break;
        }
    }
}