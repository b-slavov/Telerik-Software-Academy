namespace DefiningClassesPartTwo.Euclidiean3DSpace
{
    public static class CalcDistance
    {
        public static double GetDistance(Point3D firstPoint, Point3D secondPoint)
        {
            int xD = secondPoint.X - firstPoint.X;
            int yD = secondPoint.Y - firstPoint.Y;
            int zD = secondPoint.Z - firstPoint.Z;

            return System.Math.Sqrt((xD * xD) + (yD * yD) + (zD * zD));
        }
    }
}
