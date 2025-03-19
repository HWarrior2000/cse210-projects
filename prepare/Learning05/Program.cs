using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Rectangle rec1 = new Rectangle(5, 4, "gray");
        Rectangle rec2 = new Rectangle(7, 2, "pink");
        Square squ1 = new Square(6, "black");
        Square squ2 = new Square(10, "green");
        Circle cir1 = new Circle(11, "purple");
        Circle cir2 = new Circle(4, "yellow");
        shapes.Add(rec1);
        shapes.Add(rec2);
        shapes.Add(squ1);
        shapes.Add(squ2);
        shapes.Add(cir1);
        shapes.Add(cir2);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"Area: {shape.GetArea()}\nColor: {shape.GetColor()}\n");
        }
    }
}