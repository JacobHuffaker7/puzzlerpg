using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Arrow_Shot : Ability
    {
        public Arrow_Shot()
        {
            Title = "Arrow Shot";
            Description = "Skeleton shoots an arrow at an enemy.";
            AP_Cost = 0;
            TargetType = "Hero";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 5;
            top = false;
            front = true;
            bottom = false;
        }
    }
}
