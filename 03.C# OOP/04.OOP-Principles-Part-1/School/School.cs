namespace School
{
    using System.Collections.Generic;
    using System.Text;
    using Data;

    public class School
    {
        private List<SchoolClass> schoolClasses = new List<SchoolClass>();

        public School(List<SchoolClass> newClasses)
        {
            this.SchoolClasses = newClasses;
        }

        public List<SchoolClass> SchoolClasses
        {
            get
            {
                return this.schoolClasses;
            }

            set
            {
                this.schoolClasses = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            foreach (SchoolClass schlClass in this.schoolClasses)
            {
                result.AppendLine(schlClass.ToString());
            }

            return result.ToString();
        }
    }
}
