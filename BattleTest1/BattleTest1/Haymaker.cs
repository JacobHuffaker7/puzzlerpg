using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Haymaker : Ability
    {
        public Haymaker()
        {
            Title = "Haymaker";
            Description = "Nick slugs an enemy with all his might.";
            AP_Cost = 3;
            TargetType = "Enemy";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 10;
            top = false;
            front = true;
            bottom = false;
        }
    }
}
