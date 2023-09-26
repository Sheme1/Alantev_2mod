using System;

namespace Alantev_mod2;

public class Author
{
    public string Name { get; set; } // Поля 
    public int Bd { get; set; }

    public Author(string name, int bd) // Конструктор классов
    {
        Name = name;
        Bd = bd;
    }
}

public class Book
{
    public string Title { get; set; }
    public int Release {  get; set; }
    public Author Author { get; set; }// Композиция

    public Book(string title, int release, Author author) // Конутруктор классов 
    {
        Title = title;
        Release = release;
        Author = author;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Author author1 = new Author("Лев Толстой", 1828);
        Book book1 = new Book("Война и мир", 1869, author1);

        Author author2 = new Author("Федор Достоевский", 1821);
        Book book2 = new Book("Преступление и наказание", 1866, author2);

        Console.WriteLine($"Книга: {book1.Title}, Год выпуска: {book1.Release}, Автор: {book1.Author.Name}, Год рождения автора: {book1.Author.Bd}");
        Console.WriteLine($"Книга: {book2.Title}, Год выпуска: {book2.Release}, Автор: {book2.Author.Name}, Год рождения автора: {book2.Author.Bd}");

        Console.ReadKey();
    }
}