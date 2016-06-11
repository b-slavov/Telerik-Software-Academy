namespace DefiningClassesPartTwo.Euclidiean3DSpace
{
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        public Path()
        {
            this.SequenceOfPoints = new List<Point3D>();
        }

        public List<Point3D> SequenceOfPoints { get; set; }

        public void AddPoint(Point3D point)
        {
            this.SequenceOfPoints.Add(point);
        }

        public override string ToString()
        {
            var result = new StringBuilder();


            foreach (var points in this.SequenceOfPoints)
            {
                result.AppendFormat("X = {0, 3} Y = {1, 3} Z = {2, 3}\n", points.X, points.Y, points.Z);
            }

            return result.ToString().TrimEnd('\n');
        }
    }
}
