namespace OrderStudents
{
    using System;
    using System.Linq;

    public class OrderByDescending
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

            // Lambda expression:
            var sortedStudents = students
               .OrderByDescending(st => st.firstName)
               .ThenByDescending(st => st.lastName);

            // LINQ query:
            // var sortedStudents =
            //    from st in students
            //    orderby st.FirstName descending, st.LastName descending 
            //    select st;
            foreach (var student in sortedStudents)
            {
                Console.WriteLine("{0} {1}, age: {2}", student.firstName, student.lastName, student.age);
            }
        }
    }
}
