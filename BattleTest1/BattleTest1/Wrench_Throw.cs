using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Wrench_Throw : Ability
    {
        public Wrench_Throw()
        {
            Title = "Wrench Throw";
            Description = "Holmes throws a wrench at an enemy.";
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
