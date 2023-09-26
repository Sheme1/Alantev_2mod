using System;

public abstract class Shape// Абстракный класс родитель
{
    public abstract double Area();
    public abstract double Perimeter();
}

public class Circle : Shape//Дочерний класс "Круг"
{
    private double radius; // Поле радиуса

    public Circle(double radius) //Конструктор класса
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

public class Rectangle : Shape//Дочерний класс "Прямоугольник"
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

class Program
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

        Console.ReadKey();
    }
}
