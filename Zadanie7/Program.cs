namespace Alantev_mod2;
public struct train
{
    public string Naz_punkt;
    public int Nom_poezd;
    public DateTime Vrem_otpr;
}
class Programm
{
    static void Main(string[] args)
    {
        train[] trains = new train[5];

        for (int i = 0; i < trains.Length; i++)
        {
            Console.WriteLine($"Введите данные для поезда под номером: {i + 1}");
            Console.WriteLine($"Введите название пункта прибытия для поезда под номером: {i + 1}"); 
            string naz_punkt = Console.ReadLine();
            int nom_poezd = i + 1;
            Console.Write("Введите время отправления (формат: час:минуты): ");
            DateTime vrem_otpr = Convert.ToDateTime(Console.ReadLine());

            trains[i] = new train
            {
                Naz_punkt = naz_punkt,
                Nom_poezd = nom_poezd,
                Vrem_otpr = vrem_otpr
            };
        }
        int variant;
        Console.WriteLine("Выберите номер поезда");
        variant = Convert.ToInt32(Console.ReadLine());
        switch (variant)
        {
            case 1:
                Console.WriteLine($"Пункт прибытия: {trains[0].Naz_punkt}");
                Console.WriteLine($"Номер поезда: {trains[0].Nom_poezd}");
                Console.WriteLine($"Время отправления: {trains[0].Vrem_otpr}");
                break;
            case 2:
                Console.WriteLine($"Пункт прибытия: {trains[1].Naz_punkt}");
                Console.WriteLine($"Номер поезда: {trains[1].Nom_poezd}");
                Console.WriteLine($"Время отправления: {trains[1].Vrem_otpr}");
                break;
            case 3:
                Console.WriteLine($"Пункт прибытия: {trains[2].Naz_punkt}");
                Console.WriteLine($"Номер поезда: {trains[2].Nom_poezd}");
                Console.WriteLine($"Время отправления: {trains[2].Vrem_otpr}");
                break;
            case 4:
                Console.WriteLine($"Пункт прибытия: {trains[3].Naz_punkt}");
                Console.WriteLine($"Номер поезда: {trains[3].Nom_poezd}");
                Console.WriteLine($"Время отправления: {trains[3].Vrem_otpr}");
                break;
            case 5:
                Console.WriteLine($"Пункт прибытия: {trains[4].Naz_punkt}");
                Console.WriteLine($"Номер поезда: {trains[4].Nom_poezd}");
                Console.WriteLine($"Время отправления: {trains[4].Vrem_otpr}");
                break;
            default:
                Console.WriteLine("Поезд не найден");
                break;
        }
    }
}