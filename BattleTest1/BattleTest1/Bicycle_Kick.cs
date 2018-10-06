using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Bicycle_Kick : Ability
    {
        public Bicycle_Kick()
        {
            Title = "Bicycle Kick";
            Description = "You know Fox's Up-Smash? That.";
            AP_Cost = 0;
            TargetType = "Hero";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 6;
            top = false;
            front = false;
            bottom = true;
        }
    }
}
