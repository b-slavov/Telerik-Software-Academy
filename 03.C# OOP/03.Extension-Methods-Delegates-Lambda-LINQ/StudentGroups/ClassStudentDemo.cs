namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClassStudentDemo
    {
        private static List<Student> students;

        public static void Main()
        {
            Console.WindowWidth += 15;
            Console.WindowHeight += 30;

            students = new List<Student> 
            {
                new Student(
                    firstName: "Marshall",
                    lastName: "Mathers",
                    fn: "101006",
                    tel: "0888 555 555", 
                    email: "eminem@gmail.com",
                    marks: new List<int> { 3, 4 },
                    groupNumber: 2,
                    group: new Group(2, "Informatics")),

                new Student(
                    firstName: "Earl",
                    lastName: "Simmons",
                    fn: "102020",
                    tel: "0898 123 123", 
                    email: "dmx@gmail.com",
                    marks: new List<int> { 6, 5 },
                    groupNumber: 2,
                    group: new Group(2, "Informatics")),

                new Student(
                    firstName: "Tupac",
                    lastName: "Shakur",
                    fn: "102001",
                    tel: "0882 222 222", 
                    email: "2pac@yahoo.com",
                    marks: new List<int> { 5, 3, 4 },
                    groupNumber: 1,
                    group: new Group(1, "Mathematics")),

                new Student(
                    firstName: "Stanislav",
                    lastName: "Naydenov",
                    fn: "103303",
                    tel: "02 56 56 56", 
                    email: "spens@abv.bg",
                    marks: new List<int> { 6, 6, 6 },
                    groupNumber: 2,
                    group: new Group(2, "Informatics")),

                    new Student(
                    firstName: "William",
                    lastName: "Roberts",
                    fn: "106161",
                    tel: "0888 111 222", 
                    email: "rickross@yahoo.com",
                    marks: new List<int> { 2, 2 },
                    groupNumber: 2,
                    group: new Group(2, "Informatics"))
            };

            // conditions
            GetStudentsFromGroup2();
            GetStudentsFromABV();
            GetStudentsFromSofia();
            GetExcellentStudents();
            GetStudentsWithTwoMarks2();
            GetMarksFrom2006();
            GetMathematics();
        }

        public static void Print(IEnumerable<Student> students)
        {
            foreach (var st in students)
            {
                Console.WriteLine(st);
                Console.WriteLine();
            }

            Console.WriteLine(new string('-', Console.WindowWidth));
        }

        public static void GetStudentsFromGroup2()
        {
            Console.WriteLine("ALL STUDENTS FROM GROUP 2:\n");

            // LINQ query
            // var studentsFromGroup2 =
            //   from st in students
            //   where st.GroupNumber == 2
            //   orderby st.FirstName
            //   select st;

            // Lambda expression
            var studentsFromGroup2 = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);

            Print(studentsFromGroup2);
        }

        public static void GetStudentsFromABV()
        {
            Console.WriteLine("ALL STUDENTS THAT HAVE EMAIL IN ABV.BG:\n");

            // LINQ query
            // var studentsAbv =
            //    from st in students
            //    where st.Email.Contains("@abv.bg")
            //    select st;

            // Lambda expression
            var studentsAbv = students.Where(st => st.Email.Contains("@abv.bg"));

            Print(studentsAbv);
        }

        public static void GetStudentsFromSofia()
        {
            Console.WriteLine("ALL STUDENTS WITH PHONES IN SOFIA:\n");

            // LINQ query
            var studentsAbv =
                from st in students
                where st.Tel.StartsWith("02")
                select st;

            Print(studentsAbv);
        }

        public static void GetExcellentStudents()
        {
            Console.WriteLine("ALL STUDENTS THAT HAVE AT LEAST ONE MARK 6:\n");

            // LINQ query
            var excellentStudents =
                from st in students
                where st.Marks.Contains(6)
                select new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks };

            foreach (var st in excellentStudents)
            {
                Console.WriteLine("{0}, {1}\n", st.FullName, string.Join("-", st.Marks));
            }

            Console.WriteLine(new string('-', Console.WindowWidth));
        }

        public static void GetStudentsWithTwoMarks2()
        {
            Console.WriteLine("ALL STUDENTS THAT HAVE EXACTLY TWO MARKS \"2\":\n");

            // Lambda expression
            var someStudents = students
                .Where(st => st.Marks.Count == 2 && st.Marks.All(o => o == 2))
                .Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.Marks });

            foreach (var st in someStudents)
            {
                Console.WriteLine("{0}, {1}\n", st.FullName, string.Join("-", st.Marks));
            }

            Console.WriteLine(new string('-', Console.WindowWidth));
        }

        public static void GetMarksFrom2006()
        {
            Console.WriteLine("ALL MARKS OF THE STUDENTS THAT ENROLLED IN 2006:\n");

            // Lambda expression
            var marksFrom2006 = students
                .Where(st => st.Fn.Substring(4, 2).Equals("06"))
                .Select(st => new { FullName = st.FirstName + " " + st.LastName, Fn = st.Fn, Marks = st.Marks });

            foreach (var st in marksFrom2006)
            {
                Console.WriteLine("{0}, № {1}, {2}\n", st.FullName, st.Fn, string.Join("-", st.Marks));
            }

            Console.WriteLine(new string('-', Console.WindowWidth));
        }

        public static void GetMathematics()
        {
            Console.WriteLine("ALL STUDENTS FROM MATHEMATICS DEPARTMENT:\n");

            var allFromMathematics = students
                .Where(st => st.Group.DepartmentName.Equals("Mathematics"))
                .Select(st => new
                {
                    FullName = st.FirstName + " " + st.LastName,
                    Department = st.Group.DepartmentName,
                    DepartmentNumber = st.GroupNumber
                });

            foreach (var st in allFromMathematics)
            {
                Console.WriteLine("{0} {1} - {2}\n", st.DepartmentNumber, st.Department, st.FullName);
            }

            Console.WriteLine(new string('-', Console.WindowWidth));
        }
    }
}