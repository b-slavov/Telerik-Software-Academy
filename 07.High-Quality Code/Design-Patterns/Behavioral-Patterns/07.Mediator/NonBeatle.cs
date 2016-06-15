namespace Mediator
{
    using System;

    public class NonBeetle : Participant
    {
        public NonBeetle(string name)
            : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.Write("To a non-Beetle: ");
            base.Receive(from, message);
        }
    }
}
