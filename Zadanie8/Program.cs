namespace Alantev_mod2;

class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите радиус круга");
        double rad = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(rad);
        Console.WriteLine($"Круг: Площадь = {circle.Area()}, Периметр = {circle.Perimeter()}");
        Console.WriteLine("----------------------------------------------");
        Console.WriteLine("Введите ширину прямоугольника");
        double w = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту прямоугольника");
        double h = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(w, h);
        Console.WriteLine($"Прямоугольник: Площадь = {rectangle.Area()}, Периметр = {rectangle.Perimeter()}");
        Console.WriteLine("Введите стороны треугольника a");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите стороны треугольника b");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите стороны треугольника c");
        double c = Convert.ToDouble(Console.ReadLine());
        Triangle triangle = new Triangle(a,b,c);
        Console.WriteLine($"Треугольник: Площадь = {triangle.Area()}, Периментр = {rectangle.Perimeter()}");
    }
}

public abstract class Geo_figures
{
    public abstract double Area();
    public abstract double Perimeter();
}

class Circle : Geo_figures
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }

    public override double Perimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : Geo_figures
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double Area()
    {
        return width * height;
    }

    public override double Perimeter()
    {
        return 2 * (width + height);
    }
}

class Triangle : Geo_figures
{
    private double a;
    private double b;
    private double c;

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double Perimeter()
    {
        return a + b + c;
    }

    public override double Area()
    {
        double p = Perimeter() / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
}