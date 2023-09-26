using System;
using System.Security.Cryptography.X509Certificates;

namespace Alantev_mod1;

class Vivod
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.setValues();
    }
}

public class Person
{
    //Определение полей
    private string name;
    private int age;
    private string adres;

    public string Name// Определение базовых свойств
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Adres
    {
        get { return adres; }
        set { adres = value; }
    }
    public void setValues() // Функция по установки значений полей
    {
        try
        {
            Console.WriteLine("Введите своё имя");
            name = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите свой адрес");
            adres = Console.ReadLine();
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(adres)) //Обработка исключения ввода пустых полей
            {
                throw new ArgumentException();
            }
            getAll();
        }
        catch
        {
            Console.WriteLine("Введите корректные данные");
            setValues();
        }
        
    }

    public void getAll()// Функция выводы значения полей 
    {
        int variant;
        Console.WriteLine("Выберите какие данные вывести");
        Console.WriteLine("1. Вывод имени");
        Console.WriteLine("2. Вывод возраста");
        Console.WriteLine("3. Вывод адреса");
        Console.WriteLine("4. Вывод всего");
        variant = Convert.ToInt32(Console.ReadLine());
        switch (variant)
        {
            case 1:
                Console.WriteLine("Ваше имя: " + name);
                break;
            case 2:
                Console.WriteLine("Ваш возраст: " + age);
                break;
            case 3:
                Console.WriteLine("Ваш адрес: " + adres);
                break;
            case 4:
                Console.WriteLine("Ваше имя: " + name);
                Console.WriteLine("Ваш возраст: " + age);
                Console.WriteLine("Ваш адрес: " + adres);
                break;
        }
    }
}