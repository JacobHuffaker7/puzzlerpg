using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Fridge_Beam : Ability
    {
        public Fridge_Beam()
        {
            Title = "Fridge Beam";
            Description = "A weak beam of frost from the mini-fridge.";
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
