using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Heavy_Metal : Ability
    {
        public Heavy_Metal()
        {
            Title = "Heavy Metal";
            Description = "A wave of metal damage sweeps over the enemy team.";
            AP_Cost = 10;
            TargetType = "Enemy";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 10;
            top = false;
            front = false;
            bottom = false;
        }

        public override void setTargets(Space[] grid, int index)
        {
            foreach(Space space in grid)
            {
                if(space.creature != null)
                {
                    if(space.creature.CurrHP > 0)
                    {
                        Targets.Add(space);
                    }
                }
            }
        }
    }
}
