using ISIP523_Glushkov.Model.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            while (player.Health.current_health >= 0)
            {
                count++;
                if (count >= 10 || count % 5 == 0)
                {

                }
                else if (ISIP523_Glushkov.Model.Action.Random.Next(11) < 5)
                {

                }
            }
        }
    }
}
