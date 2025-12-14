using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Mobs
{
    public class Mage : Monster
    {
        public int Frost = 40;

        public Mage(string name, int hp, int damage, int defence, int frost)
            : base(name, hp, damage, defence)
        {
            Frost = frost;
        }
    }
}
