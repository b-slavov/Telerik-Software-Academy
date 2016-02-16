namespace PassableAndUnpassable
{
    using System;

    class LabyrinthStart
    {
        static void Main()
        {
            var labyrinth = new Labyrinth(10);

            Console.WriteLine("Empty labyrinth:\n");
            labyrinth.Print();
            Console.WriteLine();
            labyrinth.Fill();
            Console.WriteLine("Filled labyrinth:\nPassable cells filled with numbers, unpassable - with 'u' or 'X'\n");
            labyrinth.Print();
        }
    }
}