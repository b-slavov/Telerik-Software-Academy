namespace DefiningClassesPartTwo.Euclidiean3DSpace
{
    using System;

    public class SpaceDemo
    {
        public static void Main()
        {
            Point3D firstPoint = new Point3D(2, -1, 1);
            Point3D secondPoint = new Point3D();

            Console.WriteLine("Distance between\n{0} and\n{1} is: {2}\n", firstPoint, secondPoint, CalcDistance.GetDistance(firstPoint, secondPoint));

            Path path = new Path();
            path.AddPoint(new Point3D(10, 0, 0));
            path.AddPoint(new Point3D(-2, -2, -2));
            path.AddPoint(new Point3D(1, 0, 4));
            path.AddPoint(Point3D.Oo);
            path.AddPoint(new Point3D(3, 13, 0));

            PathStorage.SavePath(path); // path is saved in ListOfPaths.txt
            Console.WriteLine("Loaded path:\n{0}", PathStorage.LoadPath());
        }
    }
}