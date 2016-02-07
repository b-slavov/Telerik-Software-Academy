namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HumanDemo
    {
        public static void Main()
        {
            var students = new List<Student> 
            {
                new Student("Jonathan", "Smith", 1),
                new Student("Nasir", "Jones", 1),
                new Student("Joseph", "Cartagena", 2),
                new Student("Hristo", "Petrov", 4),
                new Student("Radric", "Davis", 3),
                new Student("Sochitta", "Sal", 3),
                new Student("Antoine", "McColister", 3),
                new Student("Andre", "Young", 1),
                new Student("O'Shea", "Jackson", 2),
                new Student("Yavor", "Yanakiev", 2),
            };

            var studentsByGrade = students.OrderBy(st => st.Grade);
            Console.WriteLine(string.Join("\n", studentsByGrade));
            Console.WriteLine();

            var workers = new List<Worker> 
            {
                new Worker("Tupac", "Shakur", 1000, 14),
                new Worker("Stanislav", "Naydenov", 600, 5),
                new Worker("Marshall", "Mathers", 30000, 8),
                new Worker("Earl", "Simmons", 15000, 8),
                new Worker("Mary", "Blige", 17000, 10),
                new Worker("William", "Roberts", 12000, 12),
                new Worker("Dwayne", "Carter", 10000, 12),
                new Worker("Kimberly", "Jones", 9000, 8),
                new Worker("Curtis", "Jackson", 10000, 10),
                new Worker("Jayceon", "Taylor", 900, 10)
            };

            var workersByMoneyPerHour = workers.OrderByDescending(w => w.MoneyPerHour());
            Console.WriteLine(string.Join("\n", workersByMoneyPerHour));
            Console.WriteLine();

            // merge lists
            var bothStudentsAndWorkers = students.Concat<Human>(workers).ToList();

            bothStudentsAndWorkers = bothStudentsAndWorkers
                .OrderBy(human => human.FirstName)
                .ThenBy(human => human.LastName).ToList();

            Console.WriteLine(string.Join("\n", bothStudentsAndWorkers));
        }
    }
}