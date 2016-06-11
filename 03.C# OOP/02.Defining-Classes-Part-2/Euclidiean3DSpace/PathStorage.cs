namespace DefiningClassesPartTwo.Euclidiean3DSpace
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void SavePath(Path pathToWrite)
        {
            var pathWriter = new StreamWriter(@"..\..\ListOfPaths.txt", false);

            using (pathWriter)
            {
                foreach (var path in pathToWrite.SequenceOfPoints)
                {
                    pathWriter.WriteLine("{0, 3}, {1, 3}, {2, 3}", path.X, path.Y, path.Z);
                }
            }
        }

        public static Path LoadPath()
        {
            var pathToLoad = new Path();
            var pathReader = new StreamReader(@"..\..\ListOfPaths.txt");

            using (pathReader)
            {
                string line = pathReader.ReadLine();
                while (line != null)
                {
                    int[] xyz = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(cor => int.Parse(cor)).ToArray();
                    pathToLoad.AddPoint(new Point3D(xyz[0], xyz[1], xyz[2]));
                    line = pathReader.ReadLine();
                }
            }

            return pathToLoad;
        }
    }
}
