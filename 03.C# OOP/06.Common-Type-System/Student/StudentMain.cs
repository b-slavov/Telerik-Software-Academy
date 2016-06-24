namespace Student
{
    using System;

    public class StudentMain
    {
        public static void Main()
        {
            // test Equal()
            var firstStudent = new Student("Marshall", "Bruce", "Mathers", 113);
            firstStudent.Email = "notChanged@abv.bg";

            var secondStudent = new Student("Tupac", "Amaru", "Shakur", 113, Universities.UNWE, Faculties.BusinessFaculty, Specialties.IndustrialBusiness);

            bool isEqualStrings = firstStudent.Equals(secondStudent);

            Console.WriteLine("{0}\n{1}\nAre they equal? -> {2}\n", firstStudent, secondStudent, isEqualStrings);

            // test Clone()
            var thirdStudent = firstStudent.Clone();
            thirdStudent.Email = "Changed@abv.bg";
            Console.WriteLine(firstStudent.Email);
            Console.WriteLine(thirdStudent.Email);
            Console.WriteLine();

            // test CompareTo()
            Console.WriteLine(firstStudent.CompareTo(secondStudent)); // -1 if first < second
        }
    }
}
