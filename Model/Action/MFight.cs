using ISIP523_Glushkov.Model.Mobs;
using ISIP523_Glushkov.Model.Player;
using ISIP523_Glushkov.Model.Fabric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Action
{
    internal class MFight
    {

        public void MOBFight(Hero player)
        {
            int dodge = 0;
            bool frost = false;
            bool dodge1 = false;
            Monster NewMon = RandMonstr.RandMob();
            Console.WriteLine($"Вы повстречали: {NewMon.Name}");
            while (player.Health.current_health > 0 && NewMon.HP > 0)
            {

                Console.WriteLine("Ваш ход: ");
                if (frost == true)
                {
                    frost = false;
                    Console.WriteLine("ЗАМОРОЖЕНЫ");
                    break;
                }
                else
                {
                    Console.WriteLine("1: Атака" +
                    "2: Защита");
                    int answ = Convert.ToInt32(Console.ReadLine());
                    switch (answ)
                    {
                        case 1:
                            double dam = player.Cur_Weap.Damage * (1 - NewMon.Defence / 100.0);
                            NewMon.HP -= dam;
                            Console.WriteLine($"Вы нанесли {dam} урона");
                            Console.WriteLine($"У {NewMon.Name} теперь {NewMon.HP} ХП");
                            break;
                        case 2:
                            Console.WriteLine("Вы решили уклониться!");
                            dodge = 1;
                            dodge1 = Random.Next(0, 10) <= 4 ? true : false;
                            break;
                    }
                }
                if (NewMon.HP <= 0)
                {
                    break;
                }
                Console.WriteLine("ХОД МОНСТРА");
                if (dodge1)
                {

                    Console.WriteLine("Вы увернулись от атаки!");
                    dodge1 = false;
                }
                else
                {
                    player.GetHurt(player, NewMon);
                    if (player.Health.current_health <= 0) break;
                }


            }


        }
    }
}
