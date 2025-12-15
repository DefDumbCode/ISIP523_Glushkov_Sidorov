using ISIP523_Glushkov.Model.Fabric;
using ISIP523_Glushkov.Model.Mobs;
using ISIP523_Glushkov.Model.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Action
{
    public class BFight
    {
        public void BOSSFight(Hero player)
        {
            int dodge = 0;
            int frost = 0;
            bool dodge1 = false;
            Monster NewMon = RandMonstr.RandBoss();
            Console.WriteLine($"Вы повстречали: {NewMon.Name}");
            while (player.Health.current_health > 0 && NewMon.HP > 0)
            {

                Console.WriteLine("Ваш ход: ");
                if (frost == 1)
                {
                    frost--;
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
                else if (NewMon.Name == "КОВАЛЬСКИЙ" || NewMon.Name == "ПЕСТОВ")
                {
                    player.Health.current_health -= NewMon.Damage;
                    Console.WriteLine($"Вам нанесли {NewMon.Damage} урона");
                    Console.WriteLine($"У вас теперь {player.Health.current_health} ХП");
                }
                else if (NewMon.Name == "ВВГ")
                {
                    bool krit1 = Random.Next(0, 10) <= 4 ? true : false;
                    if (krit1)
                    {
                        double dam = NewMon.Damage * (1 - player.Cur_Arm.Damage) * 1.5;
                        player.Health.current_health -= dam;
                        Console.WriteLine($"Вам нанесли {dam} урона");
                        Console.WriteLine($"У вас теперь {player.Health.current_health} ХП");
                    }
                    else
                    {
                        double dam = NewMon.Damage * (1 - player.Cur_Arm.Damage);
                        player.Health.current_health -= dam;
                        Console.WriteLine($"Вам нанесли {dam} урона");
                        Console.WriteLine($"У вас теперь {player.Health.current_health} ХП");
                    }

                }
                else if (NewMon.Name == "ПЕСТОВ" || NewMon.Name == "Мессенджер Макс")
                {
                    bool frost1 = Random.Next(0, 10) <= 4 ? true : false;
                    if (frost1)
                    {
                        double dam = NewMon.Damage * (1 - player.Cur_Arm.Damage) * 1.5;
                        player.Health.current_health -= dam;
                        Console.WriteLine($"Вам нанесли {dam} урона");
                        Console.WriteLine($"У вас теперь {player.Health.current_health} ХП");
                        Console.WriteLine("Также вы заморожены! Вы пропускаете следующих ход.");
                    }
                    else
                    {
                        double dam = NewMon.Damage * (1 - player.Cur_Arm.Damage);
                        player.Health.current_health -= dam;
                        Console.WriteLine($"Вам нанесли {dam} урона");
                        Console.WriteLine($"У вас теперь {player.Health.current_health} ХП");
                    }
            }


        }


    }
    }
}
