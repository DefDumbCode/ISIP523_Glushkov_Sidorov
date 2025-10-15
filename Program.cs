// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var Weapons = new Dictionary<string, int>()
{
    {"Деревянный меч", 50 },
    {"Каменный клинок", 75 },
    {"Железная алебарда", 100 },
    {"Нефритовый топор", 125 },
    {"Орешник", 300 }
};

var Armor = new Dictionary<string, int>()
{
    {"Обноски бездомного", 20 },
    {"Одежка вора", 25 },
    {"Обмундирование Рейнджера", 40 },
    {"Броня рыцаря", 60 },
    {"Костюм банана", 85 }
};

class Hero
{
    public string Name; //Имя будет единственным что будет запрошено
    public int HP = 250;
    public Dictionary<string, int> Weapons; //по базе деревяшка
    public Dictionary<string, int> Armor; //по базе обноски

    public Hero(string name, int hP, Dictionary<string, int> weapons, Dictionary<string, int> armor)
    {
        Name = name;
        HP = hP;
        Weapons = weapons;
        Armor = armor;
    }
    public void PrintInfo()
    {
        Console.WriteLine("Статистика вашего персонажа: ");
        Console.WriteLine($"Герой: {Name}");
        Console.WriteLine($"Здоровье: {HP}");
        Console.WriteLine($"Оружие: {Weapons}");
        Console.WriteLine($"Броня: {Armor}");
    }
}

class Monster
{
    public int HP = 100;
    public int Damage = 50;
    public int Defence = 30;

}