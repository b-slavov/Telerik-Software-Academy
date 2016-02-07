namespace DefiningClassesPartTwo.Euclidiean3DSpace
{
    using System.Collections.Generic;
    using System.Text;

    public class Path
    {
        // constructor
        public Path()
        {
            this.SequenceOfPoints = new List<Point3D>();
        }

        // automatic properties
        public List<Point3D> SequenceOfPoints { get; set; }

        // methods
        public void AddPoint(Point3D point)
        {
            this.SequenceOfPoints.Add(point);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            for (int i = 0; i < this.SequenceOfPoints.Count; i++)
            {
                result.AppendFormat("{3, -2} -> X = {0, 3} Y = {1, 3} Z = {2, 3}\n", this.SequenceOfPoints[i].X, this.SequenceOfPoints[i].Y, this.SequenceOfPoints[i].Z, i + 1);
            }

            return result.ToString().TrimEnd('\n');
        }
    }
}