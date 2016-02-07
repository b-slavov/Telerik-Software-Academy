namespace StudentsAndWorkers
{
    public class Student : Human
    {
        // constructor
        public Student(string firstName, string lastName, uint grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        // automatic properties
        public uint Grade { get; set; }

        // method
        public override string ToString()
        {
            return string.Format("{0, 20} - {1} grade", this.FirstName + " " + this.LastName, this.Grade);
        }
    }
}