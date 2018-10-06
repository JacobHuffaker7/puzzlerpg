using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Overhead_Slash : Ability
    {
        public Overhead_Slash()
        {
            Title = "Overhead Slash";
            Description = "Ash swings his sword down from above.";
            AP_Cost = 0;
            TargetType = "Enemy";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 5;
            top = true;
            front = false;
            bottom = false;
        }
        
    }
}
