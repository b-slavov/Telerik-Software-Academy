namespace Labyrinth
{
    using System;

    class Startup
    {
        static void Main()
        {
            var labyrinth = new Labyrinth(10);

            Console.WriteLine("Empty labyrinth:\n");
            labyrinth.Print();
            Console.WriteLine();
            labyrinth.Fill();
            Console.WriteLine("Filled labyrinth:\n");
            labyrinth.Print();
        }
    }
}