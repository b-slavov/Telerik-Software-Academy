namespace Person
{
    using System.Text;

    public class Person
    {
        public Person(string name, uint? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public uint? Age { get; private set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendFormat("{0}, {1} years old", this.Name, this.Age == null ? "Unknown" : this.Age.ToString());

            return result.ToString();
        }
    }
}