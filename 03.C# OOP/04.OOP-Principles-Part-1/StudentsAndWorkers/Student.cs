namespace StudentsAndWorkers
{
    public class Student : Human
    {
        public Student(string firstName, string lastName, uint grade) : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public uint Grade { get; set; }

        public override string ToString()
        {
            return string.Format("{0, 20} - {1} grade", this.FirstName + " " + this.LastName, this.Grade);
        }
    }
}
