using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Mobs.Boss
{
    public class Pestov : Skeleton
    {
        public int Frost = 40;
        //+ скипает броню от скелета
        public Pestov(string name, int hp, int damage, int defence, int frost)
            : base(name, hp, damage, defence)
        {
            Frost = frost;
        }
    }
}
