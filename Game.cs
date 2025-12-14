using ISIP523_Glushkov.Model.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISIP523_Glushkov.Model.Fabric;

namespace ISIP523_Glushkov
{
    internal class Game
    {
        public Hero player;
        int count = 0;


        public void Start_game()
        {
            Console.WriteLine("как тебя звать?");
            string a = Console.ReadLine();

            player = new Hero(a);

            player.PrintInfo();

            while (player.Health.current_health > 0)
            {
                count++;
                int move = ISIP523_Glushkov.Model.Action.Random.Next(1, 3);
                if (count >= 10 || count % 5 == 0)
                {
                    Console.WriteLine("БОСС!");
                    BOSSFight(player);
                }
                else if (move == 1)
                {
                    Loot();
                }
                else
                {
                    Console.WriteLine("Вы встретили врага!");
                    MOBFight(player);
                }
            }
            Console.WriteLine($"ВЫ УМЕРЛИ! Вы прошли {count} этажей!");
        }
    }
}
