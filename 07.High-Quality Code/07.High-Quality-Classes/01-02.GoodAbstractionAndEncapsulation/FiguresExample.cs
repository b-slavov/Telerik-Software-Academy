namespace AbstractionAndEncapsulation
{
    using System;

    internal class FiguresExample
    {
        internal static void Main()
        {
            var circle = new Circle(5);
            Console.WriteLine("Circle with perimeter: {0:F2} and surface: {1:F2}.", circle.CalcPerimeter(), circle.CalcSurface());

            var rect = new Rectangle(2, 3);
            Console.WriteLine("Rectangle with perimeter: {0:F2} and surface: {1:f2}.", rect.CalcPerimeter(), rect.CalcSurface());
        }
    }
}