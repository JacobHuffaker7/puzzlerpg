using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Song_Of_Comfort : Ability
    {
        public Song_Of_Comfort()
        {
            Title = "Song of Comfort";
            Description = "A soothing melody that heals each ally 3 HP.";
            AP_Cost = 3;
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
                    recipient.CurrHP += 3;
                    if (recipient.CurrHP > recipient.MaxHP)
                        recipient.CurrHP = recipient.MaxHP;
                }
            }
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
