namespace Computers.Logic.VideoCards
{
    using System;
    
    public abstract class VideoCard
    {
        public void Draw(string textMessage)
        {
            Console.ForegroundColor = this.GetColor();
            Console.WriteLine(textMessage);
            Console.ResetColor();
        }

        protected abstract ConsoleColor GetColor();
    }
}