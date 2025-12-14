using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Mobs
{
    public class Monster
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
        public virtual void TakeDamage(int damage)
        {
            HP -= damage;
        }
    }
    
    
    
}
