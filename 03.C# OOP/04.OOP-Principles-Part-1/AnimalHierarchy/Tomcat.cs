namespace AnimalHierarchy
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, uint age)
            : base(name, age, Gender.Male)
        { 
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Mrrr!");
        }
    }
}
