using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Mobs
{
    public class Slime
    {
        public int Crit = 4;

        public Goblin(string name, int hp, int damage, int defence, int krit)
        : base(name, hp, damage, defence)
        {
            Crit = krit;
        }
    }
}
