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
            switch (random.Next(0, 4))
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
                case 3:
                    return new Slime("Слизень", 100, 50, 50);
                    break;

                default: return new Goblin("Гоблин", 100, 30, 40, 4);
            }
        }

        public static Monster RandBoss()
        {
            Random random = new Random();
        switch (random.Next(0, 4))
        {
            case 0:
                    return new Goblin("ВВГ", 200, 75, 36, 50);
                    break;
            case 1:
                    return new Skeleton("КОВАЛЬСКИЙ", 250, 65, 42);
                    break;
            case 2:
                    return new Mage("Мессенджер Макс", 180, 80, 33, 50);
                    break;
            case 3:
                    return new Mage("ПЕСТОВ", 150, 90, 3, 55);
                    break;

            default: return new Goblin("ВВГ", 200, 75, 36, 50); ;
        }
        }

    }

    
}
