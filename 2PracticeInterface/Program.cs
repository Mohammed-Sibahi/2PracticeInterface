using System;

public interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
}

public class Circle : IShape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Triangle : IShape
{
    public double Side1 { get; set; }
    public double Side2 { get; set; }
    public double Side3 { get; set; }

    public Triangle(double side1, double side2, double side3)
    {
        Side1 = side1;
        Side2 = side2;
        Side3 = side3;
    }

    public double CalculateArea()
    {
        double s = (Side1 + Side2 + Side3) / 2;
        return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
    }

    public double CalculatePerimeter()
    {
        return Side1 + Side2 + Side3;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Length { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public double CalculateArea()
    {
        return Length * Width;
    }

    public double CalculatePerimeter()
    {
        return 2 * (Width + Length);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Circle circle1 = new Circle(6);
        Triangle triangle1 = new Triangle(3, 4, 6);
        Rectangle rectangle1 = new Rectangle(6, 8);

        DisplayShapeInfo(circle1);
        DisplayShapeInfo(triangle1);
        DisplayShapeInfo(rectangle1);
    }

    public static void DisplayShapeInfo(IShape shape)
    {
        Console.WriteLine($"Shape type: {shape.GetType().Name}");
        Console.WriteLine($"Area: {shape.CalculateArea()}");
        Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
        Console.WriteLine();
    }
}
