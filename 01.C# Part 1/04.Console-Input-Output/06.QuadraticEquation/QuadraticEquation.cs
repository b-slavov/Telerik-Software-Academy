using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter coefficients of a quadratic equation ax2+bx+c=0.");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        double d = (b * b) - (4 * a * c);
        double d1 = Math.Sqrt(d);

        if (d < 0)
        {
            Console.WriteLine("The equation don't have real roots.");
        }
        else if (d == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("The equation have one real root: x1 = x2 = {0}", x);
        }
        else
        {
            double x1 = (-b + d1) / (2 * a);
            double x2 = (-b - d1) / (2 * a);
            Console.WriteLine("The equation have two real roots: x1 = {0} and x2 = {1}", x1, x2);
        }
    }
}