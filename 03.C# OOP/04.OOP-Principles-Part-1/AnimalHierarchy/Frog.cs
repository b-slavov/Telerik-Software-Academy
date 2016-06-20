namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal
    {
        public Frog(string name, uint age, Gender sex)
            : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Kwak!");
        }
    }
}
