namespace Cooking
{
    public class Potato
    {
        private bool isRotten = true;
        private bool isPeeled = true;

        internal Potato()
        {
        }

        public bool IsRotten
        {
            get { return this.isRotten; }
        }

        public bool IsPeeled
        {
            get { return this.isPeeled; }
        }
    }
}
