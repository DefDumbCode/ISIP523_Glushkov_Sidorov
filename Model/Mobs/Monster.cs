using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Mobs
{
    internal class Monster
    {
        public int ID;
        public string Name;
        public int HP;
        public int Damage;
        public int Defence;

        public virtual void TakeDamage(int damage)
        {
            HP -= damage;
        }
    }
    
    
    
}
