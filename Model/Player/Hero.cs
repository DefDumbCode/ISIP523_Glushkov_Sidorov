using ISIP523_Glushkov.Model.Action;
using ISIP523_Glushkov.Model.Items;
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

        
      
    }
}
