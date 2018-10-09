using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class For_Whom_The_Bell_Tolls : Ability
    {
        public For_Whom_The_Bell_Tolls()
        {
            Title = "For Whom the Bell Tolls";
            Description = "Rachel uses ninlitsu to summon a bell to drop on an enemy.";
            AP_Cost = 3;
            TargetType = "Enemy";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 8;
            top = true;
            front = false;
            bottom = false;
        }
    }
}
