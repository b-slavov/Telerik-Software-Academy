namespace AnimalHierarchy
{
    using System;

    public class Tomcat : Cat
    {
        // constructor
        public Tomcat(string name, uint age)
            : base(name, age, Gender.Male)
        { 
        }

        // methods
        public override void ProduceSound()
        {
            Console.WriteLine("Mrrr!");
        }
    }
}