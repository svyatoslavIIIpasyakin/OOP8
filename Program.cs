using System;

// Абстрактный класс
public abstract class Device
{
    // Абстрактные методы
    public abstract void TurnOn();
    public abstract void TurnOff();

    // Абстрактное свойство
    public abstract string Name { get; }
}

// Производный класс 1
public class SmartPhone : Device
{
    // Реализация абстрактных методов
    public override void TurnOn()
    {
        Console.WriteLine($"{Name} is turning on...");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Name} is turning off...");
    }

    // Реализация абстрактного свойства
    public override string Name => "SmartPhone";

    // Индивидуальные методы и свойства
    public void MakeCall(string number)
    {
        Console.WriteLine($"Calling {number} from {Name}...");
    }
}

// Производный класс 2
public class Laptop : Device
{
    // Реализация абстрактных методов
    public override void TurnOn()
    {
        Console.WriteLine($"{Name} is booting up...");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Name} is shutting down...");
    }

    // Реализация абстрактного свойства
    public override string Name => "Laptop";

    // Индивидуальные методы и свойства
    public void RunProgram(string programName)
    {
        Console.WriteLine($"Running {programName} on {Name}...");
    }
}

// Производный класс 3
public class SmartWatch : Device
{
    // Реализация абстрактных методов
    public override void TurnOn()
    {
        Console.WriteLine($"{Name} is booting up...");
    }

    public override void TurnOff()
    {
        Console.WriteLine($"{Name} is shutting down...");
    }

    // Реализация абстрактного свойства
    public override string Name => "SmartWatch";

    // Индивидуальные методы и свойства
    public void CheckHeartRate()
    {
        Console.WriteLine($"Checking heart rate on {Name}...");
    }
}

class Program
{
    // Функция с аргументом типа абстрактного класса
    public static void OperateDevice(Device device)
    {
        Console.WriteLine($"Operating {device.Name}:");
        device.TurnOn();
        device.TurnOff();

        // Проверка на тип устройства
        if (device is SmartPhone)
        {
            SmartPhone phone = (SmartPhone)device;
            phone.MakeCall("123456789");
        }
        else if (device is Laptop)
        {
            Laptop laptop = (Laptop)device;
            laptop.RunProgram("Visual Studio");
        }
        else if (device is SmartWatch)
        {
            SmartWatch watch = (SmartWatch)device;
            watch.CheckHeartRate();
        }

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Создание экземпляров классов
        Device[] devices = new Device[]
        {
            new SmartPhone(),
            new Laptop(),
            new SmartWatch()
        };

        // Вызов функции с разными экземплярами классов
        foreach (Device device in devices)
        {
            OperateDevice(device);
        }
    }
}
