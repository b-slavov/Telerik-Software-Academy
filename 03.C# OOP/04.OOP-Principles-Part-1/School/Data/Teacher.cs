namespace Data
{
    using System.Collections.Generic;

    public class Teacher : Person
    {
        private List<Discipline> disciplines = new List<Discipline>();

        public Teacher(string firstName, string lastName, List<Discipline> disciplines, string comment = null)
            : base(firstName, lastName, comment)
        {
            this.Disciplines = disciplines;
        }

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
