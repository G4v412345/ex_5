class Program
{
    static void Main(string[] args)
    {
        Meansofreplanting[] arr = new Meansofreplanting[3];
        arr[0] = new Plane(55, 2, "Боинг", 2021, 55, 55, 55);
        arr[1] = new Car(44, 8, "Мазда", 2020, 5, 58);
        arr[2] = new Ship(40, 540, "Титаник", 1958, 55, 77);

        foreach (Meansofreplanting i in arr)
        {
            i.DisplayInfo();
            Console.WriteLine($"Срок службы: {i.ServiceLife()}\n");
        }
    }
}

abstract class Meansofreplanting
{
    public int speed;
    public int fuel;
    public string manufacturer;
    public int year;

    public Meansofreplanting(int speed, int fuel, string manufacturer, int year)
    {
        this.speed = speed;
        this.fuel = fuel;
        this.manufacturer = manufacturer;
        this.year = year;
    }

    public abstract void DisplayInfo();

    public abstract int ServiceLife();
}

class Plane : Meansofreplanting
{
    public int altitude;
    public int maxRange;
    public int numSeats;

    public Plane(int speed, int fuel, string manufacturer, int year, int altitude, int maxRange, int numSeats) : base(speed, fuel, manufacturer, year)
    {
        this.altitude = altitude;
        this.maxRange = maxRange;
        this.numSeats = numSeats;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Самолет: {manufacturer} {year}\nСкорость: {speed} \nРасход топлива: {fuel} \nВысота полета: {altitude} \nМаксимальная дальность полета: {maxRange} \nКоличество посадочных мест: {numSeats}");
    }

    public override int ServiceLife()
    {
        return 50; 
    }
}

class Car : Meansofreplanting
{
    public int engineVolume;
    public int numSeats;

    public Car(int speed, int fuel, string manufacturer, int year, int engineVolume, int numSeats) : base(speed, fuel, manufacturer, year)
    {
        this.engineVolume = engineVolume;
        this.numSeats = numSeats;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Машина: {manufacturer}\nСкорость: {speed} km/h\nРасход топлива: {fuel} \nОбъем двигателя: {engineVolume} \nКоличество посадочных мест: {numSeats}");
    }

    public override int ServiceLife()
    {
        return 50; 
    }
}

class Ship : Meansofreplanting
{
    public int displacement;
    public int numSeats;

    public Ship(int speed, int fuel, string manufacturer, int year, int displacement, int numSeats): base(speed, fuel, manufacturer, year)
    {
        this.displacement = displacement;
        this.numSeats = numSeats;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Корабль: {manufacturer} {year}\nСкорость: {speed} \nРасход топлива: {fuel} \nВодоизмещение: {displacement} \nКоличество посадочных мест: {numSeats}");
    }

    public override int ServiceLife()
    {
        return 50; 
    }
}