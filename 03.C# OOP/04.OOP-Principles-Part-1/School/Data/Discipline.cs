namespace Data
{
    using Interfaces;

    public enum DisciplineName
    {
        Art, Geography, History, Informatics, Math, Sport, Music
    }

    public class Discipline : ICommentable
    {
        // constructor
        public Discipline(DisciplineName name, uint lecturesCount, uint exercisesCount, string comment = null)
        {
            this.Name = name;
            this.LecturesCount = lecturesCount;
            this.ExercisesCount = exercisesCount;
            this.Comment = comment;
        }

        // automatic properties
        public DisciplineName Name { get; private set; }

        public uint LecturesCount { get; set; }

        public uint ExercisesCount { get; set; }

        public string Comment { get; set; }

        // method
        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}