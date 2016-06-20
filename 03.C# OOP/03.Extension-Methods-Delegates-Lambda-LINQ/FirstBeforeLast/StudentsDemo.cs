namespace FirstBeforeLast
{
    using System;
    using System.Linq;

    public class StudentsDemo
    {
        public static void Main()
        {
            var students = new[]
            {
                new { firstName = "Marshall", lastName = "Mathers" },
                new { firstName = "Earl", lastName = "Simmons" },
                new { firstName = "Tupac", lastName = "Shakur" },
                new { firstName = "Stanislav", lastName = "Naydenov" },
                new { firstName = "William", lastName = "Roberts" }
            };

            var targetedStudents =
               from st in students
               where st.firstName.CompareTo(st.lastName) == -1
               select st;

            foreach (var student in targetedStudents)
            {
                Console.WriteLine("{0} {1}", student.firstName, student.lastName);
            }
        }
    }
}
