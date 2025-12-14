using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Items
{
    public class Armor
    {
        public string Name;
        public double Damage;

        public Armor(string name, double damage)
        {
            Name = name;
            Damage = damage;

        }

        public virtual string GetArmorInfo()
        {
            return $"{Name} (Урон: {Damage})";
        }

    }

    public class Bum : Armor
    {
        public Bum()
            : base("Обноски бездомного", 0.20) { }

    }

    public class Thief : Armor
    {
        public Thief()
            : base("Одежка вора", 0.25) { }

    }

    public class Ranger : Armor
    {
        public Ranger()
            : base("Обмундирование Рейнджера", 0.40) { }

    }
    public class Knight : Armor
    {
        public Knight()
            : base("Броня рыцаря", 0.60) { }

    }

    public class Banana : Armor
    {
        public Banana()
            : base("Костюм банана", 0.85) { }

    }
}

