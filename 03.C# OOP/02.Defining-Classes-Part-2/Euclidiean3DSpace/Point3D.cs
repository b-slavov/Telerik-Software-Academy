namespace DefiningClassesPartTwo.Euclidiean3DSpace
{
    public struct Point3D
    {
        private static readonly Point3D O = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public static Point3D Oo
        {
            get
            {
                return O;
            }
        }

        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public override string ToString()
        {
            return string.Format("X = {0,2} Y = {1,2} Z = {2,2}", this.X, this.Y, this.Z);
        }
    }
}
