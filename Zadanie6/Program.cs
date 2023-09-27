namespace Alalantev_mod2;

class Programm
{
    static void Main(string[] args)
    {
        Student student = new Student("Иван", "Иванов", 20, 4.5);
        Student student1 = new Student("Дима", "Тимашков", 18, 7.5);

        Console.WriteLine(student);
        Console.WriteLine(student1);
    }
}

class Student
{
    string Name { get; set; }
    string Second_name { get; set; }
    int Age { get; set; }
    double Sred_otm { get; set; }

    public Student(string name, string second_name, int age, double sred_otm)
    {
        Name = name;
        Second_name = second_name;
        Age = age;
        Sred_otm = sred_otm;
    }
    public override string ToString()
    {
        return $"Имя студента {Name}, Фамилия студента {Second_name}, Возраст студента {Age}, Средний балл {Sred_otm}";
    }
}