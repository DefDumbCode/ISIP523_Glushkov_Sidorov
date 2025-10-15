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

var heroi = new Hero("Ин", Weapons, Armor);
heroi.PrintInfo();

string a;

class Game
{
    public Hero player;
    public List<Monster> monsters;
    public List<Monster> bosses;
}

class Hero
{
    public string Name; //Имя будет единственным что будет запрошено
    public int HP = 250;
    public string Cur_Weapon = "Деревянный меч";
    public string Cur_Armor = "Обноски бездомного";
    public Dictionary<string, int> Weapons; //по базе деревяшка
    public Dictionary<string, int> Armor; //по базе обноски

    public Hero(string name, Dictionary<string, int> weapons, Dictionary<string, int> armor)
    {
        Name = name;
        Weapons = new Dictionary<string, int>(weapons);
        Armor = new Dictionary<string, int>(armor);
;
    }
    public void PrintInfo()
    {
        Console.WriteLine("Статистика вашего персонажа: ");
        Console.WriteLine($"Герой: {Name}");
        Console.WriteLine($"Здоровье: {HP}");
        Console.WriteLine($"Оружие: {Cur_Weapon} (урон: {Weapons[Cur_Weapon]})");
        Console.WriteLine($"Броня: {Cur_Armor} (защита: {Armor[Cur_Armor]})");
    }
}

class Monster
{
    public int HP = 100;
    public int Damage = 50;
    public int Defence = 30;

    public Monster(int hp, int damage, int defence)
    {   HP = hp;
        Damage = damage;
        Defence = defence; 
    }

}

class Goblin : Monster
{
    public int Krit = 40;

    public Goblin(int hp, int damage, int defence, int krit)
        : base(hp, damage, defence)
    {
        Krit = krit;
    }
}

class Skeleton : Monster
{
    //должен скипать броню
    public Skeleton(int hp, int damage, int defence)
        : base(hp, damage, defence)
    {

    }
}

class Pestov : Skeleton
{
    public int Frost = 40;
    //+ скипает броню от скелета
    public Pestov(int hp, int damage, int defence, int frost)
        : base(hp, damage, defence)
    {
        Frost = frost;
    }
}

class Mage : Monster
{
    public int Frost = 40;

    public Mage(int hp, int damage, int defence, int frost)
        : base(hp, damage, defence)
    {
        Frost = frost;
    }
}