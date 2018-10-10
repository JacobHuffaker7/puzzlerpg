using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Water_Blast : Ability
    {
        public Water_Blast()
        {
            Title = "Water Blast";
            Description = "Turtle sends water in every direction.";
            AP_Cost = 0;
            TargetType = "Hero";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 3;
            top = false;
            front = false;
            bottom = true;
        }
    }
}
