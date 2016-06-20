namespace School
{
    using System;
    using System.Collections.Generic;
    using Data;

    public class SchoolDemo
    {
        public static void Main()
        {
            var tupacDisciplines = new List<Discipline>
            {
                new Discipline(DisciplineName.Music, 10, 10),
                new Discipline(DisciplineName.History, 8, 8)
            };

            var studentsFromClassA = new List<Student>
            {
                new Student("Marshall", "Mathers"),
                new Student("Earl", "Simmons"),
                new Student("Mary", "Blige")
            };

            var studentsFromClassB = new List<Student>
            {
                new Student("William", "Roberts"),
                new Student("Dwayne", "Carter"),
                new Student("Kimberly", "Jones")
            };

            var teachers = new List<Teacher> 
            {
                new Teacher("Tupac", "Shakur", tupacDisciplines)
            };

            var classA = new SchoolClass(teachers, studentsFromClassA);
            var classB = new SchoolClass(teachers, studentsFromClassB);

            var school = new School(new List<SchoolClass> { classA, classB });

            Console.WriteLine(school);
        }
    }
}
