using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Items
{
    public class Weapons
    {
        public string Name;
        public int Damage;

        public Weapons(string name, int damage) 
        {
            Name = name;
            Damage = damage;

        }

        public virtual string GetWeaponInfo()
        {
            return $"{Name} (Урон: {Damage})";
        }

    }

    public class Sword : Weapons 
    {
        public Sword()
            :base ("Деревянный меч", 50) { }
        
    }

    public class Dagger : Weapons
    {
        public Dagger()
            : base("Каменный клинок", 75) { }

    }

    public class Alebarda : Weapons
    {
        public Alebarda()
            : base("Железная Алебарда", 100) { }

    }
    public class Axe : Weapons
    {
        public Axe()
            : base("Нефритовый топор", 125) { }

    }

    public class Nut : Weapons
    {
        public Nut()
            : base("Орешник", 300) { }

    }
}
