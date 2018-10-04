using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Reading_Rainbow : Ability
    {
        public Reading_Rainbow()
        {
            Title = "Reading Rainbow";
            Description = "An energy blast taught to Rachel by Master Lavar Burton.";
            AP_Cost = 0;
            TargetType = "Enemy";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 5;
            top = false;
            front = true;
            bottom = false;
        }

    }
}
