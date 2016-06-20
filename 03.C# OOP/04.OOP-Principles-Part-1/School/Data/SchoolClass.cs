namespace Data
{
    using System.Collections.Generic;
    using System.Text;
    using Interfaces;

    public class SchoolClass : ICommentable
    {
        private static char autoId = 'A';

        private List<Teacher> teachers = new List<Teacher>();

        private List<Student> students = new List<Student>();

        public SchoolClass(List<Teacher> teachers, List<Student> students, string comment = null)
        {
            this.ClassId = autoId;
            this.Teachers = teachers;
            this.Students = students;
            this.Comment = comment;

            autoId++;
        }

        public char ClassId { get; private set; }

        public string Comment { get; set; }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }

            set
            {
                this.teachers = value;
            }
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }

            set
            {
                this.students = value;
            }
        }

        public string GetDisciplines()
        {
            var classDisciplines = new HashSet<string>();

            foreach (var teacher in this.teachers)
            {
                foreach (var discipline in teacher.Disciplines)
                {
                    classDisciplines.Add(discipline.Name.ToString());
                }
            }

            return string.Join(", ", classDisciplines);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine(new string('-', 15) + string.Format("CLASS {0}", this.ClassId) + new string('-', 15));
            result.AppendLine("TEACHERS:");
            result.AppendLine(string.Join(", ", this.teachers) + '\n');
            result.AppendLine("STUDENTS:");
            result.AppendLine(string.Join(", ", this.students) + '\n');
            result.AppendLine("DISCIPLINES:");
            result.AppendLine(this.GetDisciplines());

            return result.ToString();
        }
    }
}
