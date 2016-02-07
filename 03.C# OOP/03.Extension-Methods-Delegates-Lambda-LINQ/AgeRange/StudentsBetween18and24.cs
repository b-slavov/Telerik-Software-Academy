namespace AgeRange
{
    using System;
    using System.Linq;

    public class StudentsBetween18and24
    {
        public static void Main()
        {
            var students = new[]
            {
                new { firstName = "Marshall", lastName = "Mathers", age = 21 },
                new { firstName = "Earl", lastName = "Simmons", age = 17 },
                new { firstName = "Tupac", lastName = "Shakur", age = 24 },
                new { firstName = "Stanislav", lastName = "Naydenov", age = 18 },
                new { firstName = "William", lastName = "Roberts", age = 25 }
            };

            var targetedStudents =
               from st in students
               where st.age >= 18 && st.age <= 24
               select st;

            foreach (var student in targetedStudents)
            {
                Console.WriteLine("{0} {1}, age: {2}", student.firstName, student.lastName, student.age);
            }
        }
    }
}