namespace Student
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        public Student(string firstName, string middleName, string lastName, int ssn)
            : this(firstName, middleName, lastName, ssn, Universities.SU, Faculties.FacultyOfMathematicsAndInformatics, Specialties.Informatics)
        {
        }

        public Student(
            string firstName,
            string middleName,
            string lastName,
            int ssn,
            Universities uni,
            Faculties faculty,
            Specialties specialty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = "Unknown address";
            this.MobilePhone = "Unknown phone";
            this.Email = "Unknown email";
            this.Course = 1;
            this.University = uni;
            this.Faculty = faculty;
            this.Specialty = specialty;
        }

        public string FirstName { get; private set; }

        public string MiddleName { get; private set; }

        public string LastName { get; private set; }

        public int SSN { get; set; }

        public string Address { get; set; }

        public string MobilePhone { get; set; }

        public string Email { get; set; }

        public int Course { get; set; }

        public Universities University { get; set; }

        public Faculties Faculty { get; set; }

        public Specialties Specialty { get; set; }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !Student.Equals(firstStudent, secondStudent);
        }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if ((object)student == null)
            {
                return false;
            }

            // compare value type member fields
            if (this.SSN != student.SSN)
            {
                return false;
            }

            // compare reference type member fields (String's Equal() method is overrided by default)
            if (!Student.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.FirstName.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} studies in {1}", this.FirstName + " " + this.LastName, this.University);
        }

        public Student Clone()
        {
            Student original = new Student(
                this.FirstName,
                this.MiddleName,
                this.LastName,
                this.SSN,
                this.University,
                this.Faculty,
                this.Specialty);

            original.Address = this.Address;
            original.Email = this.Email;
            original.MobilePhone = this.MobilePhone;
            original.Course = this.Course;

            return original;
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public int CompareTo(Student other)
        {
            int result = this.FirstName.CompareTo(other.FirstName);

            if (result == 0)
            {
                // if first names are equal
                result = this.LastName.CompareTo(other.LastName);
            }

            if (result == 0)
            {
                // if the last names are equal too
                return this.SSN.CompareTo(other.SSN);
            }

            return result;
        }
    }
}
