using ISIP523_Glushkov.Model.Action;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Player
{
    internal class Hero
    {
        public string Name;
        public Health Health = new Health();
        public string Cur_Weapon = "Деревянный меч";
        public string Cur_Armor = "Обноски бездомного";
        public class Weapons { }
        public class Armor { }

        public Hero(string name)
        {
            Name = name;
        }

        public void PrintInfo() 
        {
            Console.WriteLine("Статистика вашего героя \n ");
        }

        
      
    }
}
