namespace SoftwareAcademy
{
    using System;
    using System.Text;

    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Local course laboratory cannot be null!");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Local course laboratory cannot be empty string or sequence of white spaces!");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());

            result.AppendFormat("; Lab={0}", this.Lab);

            return result.ToString();
        }
    }
}
