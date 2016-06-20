﻿namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal
    {
        public Dog(string name, uint age, Gender sex)
            : base(name, age, sex)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
