using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Billable_Hours : Ability
    {
        public static int elapsed = 0;

        public Billable_Hours()
        {
            Title = "Billable Hours";
            Description = "Restores 1 AP to all teammates for each turn since its last use.";
            AP_Cost = 0;
            TargetType = "Hero";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 0;
            top = false;
            front = false;
            bottom = false;
        }


        public override void execute(Creature attacker)
        {
            foreach (Space space in Targets)
            {
                Creature recipient = space.creature;
                if (recipient != null)
                {
                    recipient.CurrAP += elapsed;
                    if (recipient.CurrAP > recipient.MaxAP)
                        recipient.CurrAP = recipient.MaxAP;
                }
            }
            Console.WriteLine("Nick cashes in his billable hours! " + elapsed + " AP restored to all heroes!");
            elapsed = 0;
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
