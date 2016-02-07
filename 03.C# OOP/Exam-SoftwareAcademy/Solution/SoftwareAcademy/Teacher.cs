namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;

        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Teacher name cannot be null!");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Teacher name cannot be empty string or sequence of white spaces!");
                }

                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendFormat("Teacher: Name={0}", this.Name);

            if (this.courses.Count > 0)
            {
                result.AppendFormat("; Courses[{0}]", string.Join(", ", this.courses.Select(c => c.Name)));
            }
            
            return result.ToString();
        }
    }
}
