namespace Shapes
{
    using System;

    public class Circle : Shape
    {
        public Circle(double diameter)
            : base(diameter, diameter)
        {
        }

        public override double CalculateSurface()
        {
            return Math.Round(Math.PI * (this.Height / 2) * (this.Height / 2), 3);
        }
    }
}
