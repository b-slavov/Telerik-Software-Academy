namespace AnimalHierarchy
{
    using System;

    public class Kitten : Cat
    {
        // constructor
        public Kitten(string name, uint age)
            : base(name, age, Gender.Female)
        {
        }

        // method
        public override void ProduceSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}