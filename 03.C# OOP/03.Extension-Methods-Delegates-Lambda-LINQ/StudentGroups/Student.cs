namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Student
    {
        public Student(string firstName, string lastName, string fn, string tel, string email, List<int> marks, int groupNumber, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Fn = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.Group = group;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Fn { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

        public Group Group { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendFormat("{0} {1}, № {2}, {3}, {4}, Group {5}, {6}", this.FirstName, this.LastName, this.Fn, this.Tel, this.Email, this.GroupNumber, string.Join("-", this.Marks));

            return result.ToString();
        }
    }
}
