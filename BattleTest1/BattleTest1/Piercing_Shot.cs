using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Piercing_Shot : Ability
    {
        public Piercing_Shot()
        {
            Title = "Piercing Shot";
            Description = "Skeleton shoots an arrow that pierces an enemies defense.";
            AP_Cost = 2;
            TargetType = "Hero";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 9;
            top = false;
            front = true;
            bottom = false;
        }
    }
}
