namespace Minesweeper
{
    public class Player
    {
        private string name;
        private int points;

        public Player()
        {
        }

        public Player(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name { get; set; }

        public int Points { get; set; }
    }
}