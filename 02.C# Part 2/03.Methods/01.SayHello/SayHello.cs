using System;

class SayHello
{
    public static string Greeting(string name)
    {
        return String.Format("Hello, {0}!", name);
    }

    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine(Greeting(name));
    }
}