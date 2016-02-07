namespace SoftwareAcademy
{
    using System;
    using System.Text;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Offsite course town cannot be null!");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentOutOfRangeException("Offsite course town cannot be empty string or sequence of white spaces!");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder(base.ToString());

            result.AppendFormat("; Town={0}", this.Town);

            return result.ToString();
        }
    }
}
