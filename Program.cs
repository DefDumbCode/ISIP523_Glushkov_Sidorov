// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

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

class  FabEnemy
{
    public static Monster RandMonstr()
    {
        Random random = new Random();
        switch (random.Next(0, 3))
        {
            case 0:
                return GetGob();
                break;
            case 1:
                return GetSkel();
                break;
            case 2:
                return GetMag();
                break;

               default : return GetGob();
        }
        
    }

    public static Monster GetGob()
    {
        return new Goblin("Гоблин", 100, 50, 30, 40);
    }
    public static Monster GetSkel()
    {
        return new Skeleton("Скелет", 100, 50, 30);
    }
    public static Monster GetMag()
    {
        return new Mage("Маг", 100, 50, 30, 40);
    }

    public static Monster RandBoss()
    {
        Random random = new Random();
        switch (random.Next(0, 4))
        {
            case 0:
                return GetVVG();
                break;
            case 1:
                return GetKov();
                break;
            case 2:
                return GetMaks();
                break;
            case 3:
                return GetPest();
                break;

            default: return GetVVG();
        }

    }

    public static Monster GetVVG()
    {
        return new Goblin("ВВГ", 200, 75, 36, 50);
    }
    public static Monster GetKov()
    {
        return new Skeleton("КОВАЛЬСКИЙ", 250, 65, 42);
    }
    public static Monster GetMaks()
    {
        return new Mage("Мессенджер Макс", 180, 80, 33, 50);
    }
    public static Monster GetPest()
    {
        return new Mage("ПЕСТОВ", 150, 90, 3, 55);
    }

}



class Game
{
    public Hero player;
    public List<Monster> monsters;
    public List<Monster> bosses;
    public List<Monster> list = new List<Monster>{ new Goblin("Гоблин", 100, 50, 30, 40), new Skeleton("Скелет", 100, 50, 30), new Mage("Маг", 100, 50, 30, 40)};
    public List<Monster> boss = new List<Monster>{ new Mage("ПЕСТОВ", 150, 90, 3, 55), new Goblin("ВВГ", 200, 75, 36, 50), new Skeleton("КОВАЛЬСКИЙ", 250, 65, 42), new Mage("Мессенджер Макс", 180, 80, 33, 50)};
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
                Fight(player);
                

            }
        }


    }

    public void Fight(Hero player)
    {
        int dodge = 0;
        bool dodge1 = false;
        Monster NewMon = FabEnemy.RandMonstr();
        Console.WriteLine($"Вы повстречали: {NewMon.Name}");
        while (player.HP != 0 || NewMon.HP != 0)
        {

            Console.WriteLine("Ваш ход: ");
            Console.WriteLine("1: Атака" +
                "2: Защита");
            int answ = Convert.ToInt32(Console.ReadLine());
            switch(answ)
            {
                case 1:
                    int dam = player.Weapons[Cur_Weapon] * (100 * NewMon.Defence);
                    NewMon.HP -= dam;
                    Console.WriteLine($"Вы нанесли {dam} урона");
                    Console.WriteLine($"У {NewMon.Name} теперь {NewMon.HP} ХП");
                    break;
                case 2:
                    Console.WriteLine("Вы решили уклониться!");
                    dodge = 1;
                    dodge1 = rnd.Next(0, 10)<=4 ? true : false;
                    break;
            }
            Console.WriteLine("ХОД МОНСТРА");
            if (dodge1)
            {
                Console.WriteLine("Вы увернулись от атаки!");
            }
            else
            {
                int dam = NewMon.Damage * (100 * player.Armor[Cur_Armor]);
                player.HP -= dam;
                Console.WriteLine($"Вам нанесли {dam} урона");
                Console.WriteLine($"У вас теперь {player.HP} ХП");
            }

            
        }

        
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
    public string Name;
    public int HP = 100;
    public int Damage = 50;
    public int Defence = 30;

    public Monster(string name, int hp, int damage, int defence)
    {
        Name = name;
        HP = hp;
        Damage = damage;
        Defence = defence; 
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Статистика {Name}: ");
        Console.WriteLine($"Здоровье: {HP}");
        Console.WriteLine($"Урон: {Damage}");
        Console.WriteLine($"Броня: {Defence}");
    }

}

class Goblin : Monster
{
    public int Krit = 40;

    public Goblin(string name, int hp, int damage, int defence, int krit)
        : base(name, hp, damage, defence)
    {
        Krit = krit;
    }
}

class Skeleton : Monster
{
    //должен скипать броню
    public Skeleton(string name, int hp, int damage, int defence)
        : base(name, hp, damage, defence)
    {

    }
}

class Pestov : Skeleton
{
    public int Frost = 40;
    //+ скипает броню от скелета
    public Pestov(string name, int hp, int damage, int defence, int frost)
        : base(name, hp, damage, defence)
    {
        Frost = frost;
    }
}

class Mage : Monster
{
    public int Frost = 40;

    public Mage(string name, int hp, int damage, int defence, int frost)
        : base(name,hp, damage, defence)
    {
        Frost = frost;
    }
}


