namespace Data
{
    using System.Collections.Generic;

    public class Teacher : Person
    {
        // fields
        private List<Discipline> disciplines = new List<Discipline>();

        // constructor
        public Teacher(string firstName, string lastName, List<Discipline> disciplines, string comment = null)
            : base(firstName, lastName, comment)
        {
            this.Disciplines = disciplines;
        }

        // properties
        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }

            set
            {
                this.disciplines = value;
            }
        }
    }
}