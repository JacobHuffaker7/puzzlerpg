using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Bear_Slash : Ability
    {
        public Bear_Slash()
        {
            Title = "Bear Slash";
            Description = "Bear attacks with powerful claws.";
            AP_Cost = 0;
            TargetType = "Hero";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 6;
            top = false;
            front = true;
            bottom = false;
        }
    }
}
