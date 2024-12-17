using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("violet", 5);

        // Console.WriteLine(s.GetColor());
        // Console.WriteLine(s.GetArea());

        Rectangle r = new Rectangle("yellow", 4,5);
        // Console.WriteLine(r.GetColor());
        // Console.WriteLine(r.GetArea());

        Circle c = new Circle("white", 7);

        // Console.WriteLine(c.GetColor());
        // Console.WriteLine(c.GetArea());

        List<Shape> shapes = new List<Shape>();

        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape i in shapes)
        {
            Console.WriteLine(i.GetColor());
            Console.WriteLine(i.GetArea());
        }

    }
}