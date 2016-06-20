namespace AnimalHierarchy
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, uint age)
            : base(name, age, Gender.Female)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
