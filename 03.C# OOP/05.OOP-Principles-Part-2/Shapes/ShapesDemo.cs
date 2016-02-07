namespace Shapes
{
    using System;
    using System.Text;

    public class ShapesDemo
    {
        public static void Main()
        {
            var triangle = new Triangle(10.5, 8.5);
            var rectangle = new Rectangle(8d, 8d);
            var circle = new Circle(5d);

            var shapes = new Shape[] 
            {
                triangle, rectangle, circle
            };

            foreach (Shape shape in shapes)
            {
                var result = new StringBuilder();
                result.AppendLine(string.Format("{0}'s surface: {1}", shape.GetType().Name, shape.CalculateSurface()));
                Console.WriteLine(result.ToString());
            }
        }
    }
}