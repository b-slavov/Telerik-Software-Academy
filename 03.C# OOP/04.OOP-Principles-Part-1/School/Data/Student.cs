namespace Data
{
    public class Student : Person
    {
        // fields
        private static uint autoId = 1; // for unique student class number

        // constructor
        public Student(string firstName, string lastName, string comment = null)
            : base(firstName, lastName, comment)
        {
            this.ClassNumber = autoId;

            autoId++;
        }

        public uint ClassNumber { get; private set; }
    }
}