using System;

namespace Alantev_mod2
{
    public interface IDrawable
    {
        void Draw();
    }

    public class Circle : IDrawable
    {
        public void Draw() //Реализация метода Draw
        {
            Console.WriteLine("Радиус круга: 15см");
        }
    }

    public class Rectangle : IDrawable
    {
        public void Draw() //Реализация метода Draw
        {
            Console.WriteLine("Прямоугольник: Высота: 5см Длинна: 15 см");
        }
    }

    public class Triangle : IDrawable
    {
        public void Draw() //Реализация метода Draw
        {
            Console.WriteLine("Треугольник: Длинна стороны: 23см");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IDrawable[] draws = new IDrawable[] { new Circle(), new Rectangle(), new Triangle() }; // Массив объектов 

            foreach (var drawable in draws)
            {
                drawable.Draw();
            }
        }
    }
}
