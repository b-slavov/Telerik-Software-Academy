namespace Cell
{
    using System;

    public static class Cell
    {
        private const int MinX = 1;
        private const int MaxX = 3;
        private const int MinY = 2;
        private const int MaxY = 4;

        private static bool isVisitableCell = true;
        private static int x = 2;
        private static int y = 3;

        public static void VisitCell()
        {
            Console.WriteLine("This cell is visited.");
        }

        public static void ShouldBeCellVisited()
        {
            bool trulyY = MinY <= y && y <= MaxY;
            bool trulyX = MinX <= x && x <= MaxX;

            if (trulyX && trulyY && isVisitableCell)
            {
                VisitCell();
            }
        }
    }
}
