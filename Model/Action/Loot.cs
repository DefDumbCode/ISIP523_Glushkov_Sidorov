using ISIP523_Glushkov.Model.Items;
using ISIP523_Glushkov.Model.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Action
{
    internal class Loot
    {
        private List<Weapons> weaponsList;
        private List<Armor> armorList;
        public Loot()
        {
          // Инициализация списков доступного оружия и брони
            weaponsList = new List<Weapons>
            {
             new Sword(),
             new Dagger(),
             new Alebarda(),
             new Axe(),
             new Nut()
            };

            armorList = new List<Armor>
            {
             new Bum(),
             new Thief(),
             new Ranger(),
             new Knight(),
             new Banana()
            };
        }

        public void FindLoot(Hero player)
        {
            Console.WriteLine("Вы нашли сундук!");
            int loot = Random.Next(1, 4);

            if (loot == 1)
            {
                Console.WriteLine("Вы нашли зелье лечения!! \n Здоровье полностью восстановлено.");
                player.Health.Heal(player.Health.Max);
            }
            else if (loot == 2)
            {
                // Нашли оружие
                int index = Random.Next(weaponsList.Count);
                Weapons foundWeapon = weaponsList[index];

                Console.WriteLine($"Вы нашли: {foundWeapon.Name}");
                Console.WriteLine($"Урон: {foundWeapon.Damage}");
                Console.WriteLine("Хотите поменять с вашим? (1 - Да; 2 - Нет)");
                Console.WriteLine($"У вас: {player.Cur_Weap.Name}");
                Console.WriteLine($"Урон: {player.Cur_Weap.Damage}");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    player.Cur_Weap = foundWeapon;
                    Console.WriteLine("Вы поменяли оружие!");
                }
            }
            else
            {
                // Нашли броню
                int index = Random.Next(armorList.Count);
                Armor foundArmor = armorList[index];

                Console.WriteLine($"Вы нашли: {foundArmor.Name}");
                Console.WriteLine($"Защита: {foundArmor.Damage * 100}%");
                Console.WriteLine("Хотите поменять с вашим? (1 - Да; 2 - Нет)");
                Console.WriteLine($"У вас: {player.Cur_Arm.Name}");
                Console.WriteLine($"Защита: {player.Cur_Arm.Damage * 100}%");

                string input = Console.ReadLine();
                if (input == "1")
                {
                    player.Cur_Arm = foundArmor;
                    Console.WriteLine("Вы поменяли броню!");
                }
            }
        }
    }
}

