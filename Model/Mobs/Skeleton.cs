using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Mobs
{
    public class Skeleton : Monster
    {
        //должен скипать броню
        public Skeleton(string name, int hp, int damage, int defence)
            : base(name, hp, damage, defence)
        {

        }
    }
}
