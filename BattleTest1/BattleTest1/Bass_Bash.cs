using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Bass_Bash : Ability
    {
        public Bass_Bash()
        {
            Title = "Bass Bash";
            Description = "Steve whacks someone over the head with his bass guitar.";
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
