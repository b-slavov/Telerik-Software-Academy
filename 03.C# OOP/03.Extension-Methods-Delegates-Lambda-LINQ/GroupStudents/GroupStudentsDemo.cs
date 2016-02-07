namespace GroupStudents
{
    using System;
    using System.Linq;

    public class GroupStudentsDemo
    {
        public static void Main()
        {
            var students = new[]
            {
                new { FirstName = "Eminem", Group = "Mathematics" },
                new { FirstName = "DMX", Group = "Geography" },
                new { FirstName = "2Pac", Group = "History" },
                new { FirstName = "Spens", Group = "Mathematics" },
                new { FirstName = "Rick Ross", Group = "History" },
                new { FirstName = "Mary J Blige", Group = "History" },
                new { FirstName = "Lil Jon", Group = "Mathematics" },
                new { FirstName = "Gucci Mane", Group = "Geography" },
                new { FirstName = "Hazarta", Group = "Mathematics" },
            };

            // 18.LINQ
            // var groupedStudents =
            //     from st in students
            //     group st by st.Group into g
            //     orderby g.Key
            //     select g;

            // 19.Lambda expression
            var groupedStudents = students.GroupBy(st => st.Group).OrderBy(g => g.Key);

            foreach (var group in groupedStudents)
            {
                foreach (var student in group)
                {
                    Console.WriteLine("{0,11} - {1}", student.Group, student.FirstName);
                }
            }
        }
    }
}