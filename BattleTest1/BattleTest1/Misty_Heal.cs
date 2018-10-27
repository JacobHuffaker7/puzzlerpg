using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Misty_Heal : Ability
    {
        public Misty_Heal()
        {
            Title = "Misty Heal";
            Description = "Turtle sends mist that heals for 5 HP to allies.";
            AP_Cost = 2;
            TargetType = "Enemy";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 0;
            top = false;
            front = false;
            bottom = false;
        }

        public override void setTargets(Space[] grid, int index)
        {
            foreach (Space space in grid)
            {
                if (space.creature != null && space.creature.Alignment == "Enemy")
                {
                    if (space.creature.CurrHP > 0)
                    {
                        Targets.Add(space);
                    }
                }
            }
        }

        public override void execute(Creature attacker)
        {
            Console.WriteLine(attacker.Name + " uses " + Title + " on allies!  All enemies but " + attacker.Name + " heal for 5 HP!\n");
            foreach (Space space in Targets)
            {
                Creature recipient = space.creature;
                if (recipient != null)
                {
                    recipient.CurrHP += 5;
                    if (recipient.CurrHP > recipient.MaxHP)
                        recipient.CurrHP = recipient.MaxHP;
                }
            }
        }
    }
}
