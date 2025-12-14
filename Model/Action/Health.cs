using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISIP523_Glushkov.Model.Action
{
    public class Health
    {
        public double current_health;
        public double Max = 250;

        public Health() 
        {
            current_health = Max;
        }

        public void Heal(double health) => current_health = Max;
    }
}
