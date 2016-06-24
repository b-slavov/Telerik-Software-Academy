namespace Person
{
    using System;

    public class PersonDemo
    {
        public static void Main()
        {
            var eminem = new Person("Marshall Mathers", 42);
            var dmx = new Person("Earl Simmons");

            Console.WriteLine(eminem);
            Console.WriteLine(dmx);
        }
    }
}
