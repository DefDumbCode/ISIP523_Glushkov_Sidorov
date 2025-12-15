using ISIP523_Glushkov.Model.Action;
using ISIP523_Glushkov.Model.Items;
using ISIP523_Glushkov.Model.Mobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Player
{
    public class Hero
    {
        public string Name;
        public Health Health = new Health();
        public Weapons Cur_Weap;
        public Armor Cur_Arm;


        public Hero(string name)
        {
            Name = name;
            Cur_Weap = new Sword();
            Cur_Arm = new Bum();
        }

        public void PrintInfo() 
        {
            Console.WriteLine($"Статистика вашего героя \n Герой: {Name} \n Здоровье: {Health.current_health} \n Оружие: {Cur_Weap.GetWeaponInfo()} \n Броня: {Cur_Arm.GetArmorInfo()}");
        }

        public void GetHurt(Hero player, Monster NewMon)
        {
            int dodge = 0;
            int frost = 0;
            bool dodge1 = false;
            System.Random rnd = new System.Random();
            double dam = 0.0;

            if (NewMon.Name == "Гоблин")
            {
                bool krit1 = rnd.Next(0, 10) <= 4 ? true : false;
                if (krit1)
                {
                    dam = NewMon.Damage * (1 - player.Cur_Arm.Damage);
                }
            }
            else if (NewMon.Name == "Скелет" || NewMon.Name == "Слизень")
            {
                dam = NewMon.Damage;
            }
            else if (NewMon.Name == "Маг")
            {
                bool frost1 = rnd.Next(0, 10) <= 4 ? true : false;
                if (frost1)
                {
                    dam = NewMon.Damage * (1 - player.Cur_Weap.Damage);
                    Console.WriteLine("Также вы заморожены! Вы пропускаете следующий ход.");
                }
            }
            player.Health.current_health -= dam;
            Console.WriteLine($"Вам нанесли {dam} урона");
            Console.WriteLine($"У вас теперь {player.Health.current_health} ХП");
        }

    }
}
