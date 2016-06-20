namespace Data
{
    using Interfaces;

    public class Discipline : ICommentable
    {
        public Discipline(DisciplineName name, uint lecturesCount, uint exercisesCount, string comment = null)
        {
            this.Name = name;
            this.LecturesCount = lecturesCount;
            this.ExercisesCount = exercisesCount;
            this.Comment = comment;
        }

        public DisciplineName Name { get; private set; }

        public uint LecturesCount { get; set; }

        public uint ExercisesCount { get; set; }

        public string Comment { get; set; }

        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
