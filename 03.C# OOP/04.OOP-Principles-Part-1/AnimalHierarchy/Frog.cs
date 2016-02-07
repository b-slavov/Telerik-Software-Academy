namespace AnimalHierarchy
{
    using System;

    // in a real project it should be an abstract class
    public class Frog : Animal
    {
        // constructor
        public Frog(string name, uint age, Gender sex)
            : base(name, age, sex)
        {
        }

        // methods
        public override void ProduceSound()
        {
            Console.WriteLine("Kwak!");
        }
    }
}