using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Wide_Swipe : Ability
    {
        public Wide_Swipe()
        {
            Title = "Wide Swipe";
            Description = "A wide slash that hits enemies next to the target.";
            AP_Cost = 0;
            TargetType = "Enemy";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 1;
            top = false;
            front = true;
            bottom = false;
        }

        public override void setTargets(Space[] grid, int index)
        {
            if (index - 1 >= 0)
                Targets.Add(grid[index - 1]);
            if (index + 1 < grid.Length)
                Targets.Add(grid[index + 1]);
            Targets.Add(grid[index]);
        }
    }
}
