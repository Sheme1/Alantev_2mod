namespace Alantev_mod2;
public delegate void Temper(double temp);
class Programm
{
    static void Main()
    {
        Thermostat temp_1 = new Thermostat();
        TemperatureSensor temper = new TemperatureSensor();
        temper.TemperatureChanged += temp_1.OnProcess;
        temper.Sensor_TemperatureChanged();
    }
}

class TemperatureSensor
{
    public event Temper TemperatureChanged;
    
    public void Sensor_TemperatureChanged()
    {
        Console.WriteLine("Введите температуру");
        double temp = Convert.ToDouble(Console.ReadLine());
        TemperatureChanged.Invoke(temp);
    }
}

class Thermostat
{
    public void OnProcess(double temp)
    {
        if (temp <=10)
        {
            Console.WriteLine($"Температура равна: {temp} обогревватель включён");
        }
        else { Console.WriteLine($"Температура равна: {temp} обогревватель выключён"); }
    }
}
