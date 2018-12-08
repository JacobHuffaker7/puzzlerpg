using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Cock_A_Doodle_Doom : Ability
    {
        public Cock_A_Doodle_Doom()
        {
            Title = "Cock-A-Doodle-Doom";
            Description = "The beast crows its fatal crow.";
            AP_Cost = 10;
            TargetType = "Hero";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 25;
            top = false;
            front = false;
            bottom = false;
        }

        public override void setTargets(Space[] grid, int index)
        {
            foreach (Space space in grid)
            {
                if (space.creature != null)
                {
                    if (space.creature.CurrHP > 0)
                    {
                        Targets.Add(space);
                    }
                }
            }
        }
    }
}
