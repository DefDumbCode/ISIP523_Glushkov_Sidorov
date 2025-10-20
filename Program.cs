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

var igra = new Game(Weapons, Armor);
Console.WriteLine(Weapons.Count);
igra.Start_game();

var gobl = new Goblin(100, 50, 30, 40);
var skel = new Skeleton(100, 50, 30);
var mag = new Mage(100, 50, 30, 40);
List <Monster> list = new List<Monster>();
list.Add(gobl);
list.Add(skel);
list.Add(mag);
var pest = new Mage(150, 90, 3, 55);
var VVG = new Goblin(200, 75, 36, 50);
var Koval = new Skeleton(250, 65, 42);
var Oreh = new Mage(180, 80, 33, 50);
List <Monster> boss = new List<Monster>();
boss.Add(pest);
boss.Add(VVG);
boss.Add(Koval);
boss.Add(Oreh);




class Game
{
    public Hero player;
    public List<Monster> monsters;
    public List<Monster> bosses;
    string a = " ";
    Random rnd = new Random();
    Dictionary<string, int> Weapons;
    Dictionary<string, int> Armor;
    public string Cur_Weapon = "Деревянный меч";
    public string Cur_Armor = "Обноски бездомного";
    int count = 0;

    public Game(Dictionary<string, int> weapons,  Dictionary<string, int> armor)
    {
        Weapons = weapons;
        Armor = armor;
    }

    public void Start_game()
    {
        Console.WriteLine("Введи своё имя герой!");
        a = Console.ReadLine();
        var player = new Hero(a, Weapons, Armor);
        player.PrintInfo();
        while(player.HP != 0 || count < 20)
        {
            int move = rnd.Next(1, 3);
            if (move == 1)
            {
                Console.WriteLine("Вы нашли сундук!");
                int loot = rnd.Next(1, 4);
                if (loot == 1)
                {
                    Console.WriteLine("Вы нашли зелье лечения!! \n Здоровье полностью восстановлено.");
                    player.HP = 100;
                }
                else if (loot == 2)
                {
                    int index = rnd.Next(Weapons.Count);
                    Console.WriteLine($"Вы нашли: {Weapons.Keys.ElementAt(index)}");
                    Console.WriteLine($"Урон: {Weapons.Values.ElementAt(index)}");
                    Console.WriteLine("Хотите поменять с вашим? (1 - Да; 2 - Нет)");
                    Console.WriteLine($"У вас: {Cur_Weapon}");
                    Console.WriteLine($"Урон: {Weapons[Cur_Weapon]}");
                    int b = Convert.ToInt32(Console.ReadLine());
                    switch (b)
                    {
                        case 1:
                            Cur_Weapon = Weapons.Keys.ElementAt(index);
                            Console.WriteLine("Вы поменяли оружие!");
                            break;
                        case 2:
                            break;
                    }
                }
                else
                {
                    int index = rnd.Next(Armor.Count);
                    Console.WriteLine($"Вы нашли: {Armor.Keys.ElementAt(index)}");
                    Console.WriteLine($"Урон: {Armor.Values.ElementAt(index)}");
                    Console.WriteLine("Хотите поменять с вашим? (1 - Да; 2 - Нет)");
                    Console.WriteLine($"У вас: {Cur_Armor}");
                    Console.WriteLine($"Урон: {Weapons[Cur_Armor]}");
                    int b = Convert.ToInt32(Console.ReadLine());
                    switch (b)
                    {
                        case 1:
                            Cur_Armor = Armor.Keys.ElementAt(index);
                            Console.WriteLine("Вы поменяли броню!");
                            break;
                        case 2:
                            break;
                    }

                }
                }
            else
            {
                Console.WriteLine("Вы встретили врага!");
                int chanse = rnd.Next(1,4);

            }
        }


    }

    public void Fight()
    {

    }

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


