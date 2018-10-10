using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Bear_Rage : Ability
    {
        public Bear_Rage()
        {
            Title = "Bear Rage";
            Description = "Enraged through battle, it increases its attack and defence.";
            AP_Cost = 5;
            TargetType = "Self";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 0;
            top = false;
            front = false;
            bottom = false;
        }

        public override void execute(Creature attacker)
        {
            foreach (Space space in Targets)//This should only affect the using creature, no one else
            {
                Creature recipient = space.creature;
                if (recipient != null)
                {
                    recipient.CurrAttack += 2;
                    recipient.CurrDefense += 2;
                    if (recipient.CurrAttack > recipient.BaseAttack + 4)
                        recipient.CurrAttack = recipient.BaseAttack + 4;
                    if (recipient.CurrDefense > recipient.BaseDefense + 4)
                        recipient.CurrDefense = recipient.BaseDefense + 4;
                }
            }
        }
    }
}
