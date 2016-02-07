namespace AnimalHierarchy
{
    using System;

    // in a real project it should be an abstract class
    public class Dog : Animal
    {
        // constructor
        public Dog(string name, uint age, Gender sex)
            : base(name, age, sex)
        {
        }

        // methods
        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}