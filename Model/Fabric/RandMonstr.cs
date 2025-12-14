using ISIP523_Glushkov.Model.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Fabric
{
    public static class RandMonstr
    {
        public static Monster RandMob()
        {
            Random random = new Random();
            switch (random.Next(0, 3))
            {
                case 0:
                    return new Goblin("Гоблин", 100, 30, 40, 4);
                    break;
                case 1:
                    return new Skeleton("Скелет", 100, 50, 30);
                    break;
                case 2:
                    return new Mage("Маг", 100, 50, 30, 40);
                    break;

                default: return new Goblin("Гоблин", 100, 30, 40, 4);
            }
        }

        public static Monster RandBoss()
        {
        }

    }

    
}
