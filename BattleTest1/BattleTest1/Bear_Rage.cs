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

        public override bool canDo(Creature attacker, Creature defender)
        {
            if (attacker == defender)
            {
                return true;
            }
            return false;
        }

        public override void execute(Creature attacker)
        {
            foreach (Space space in Targets)//This should only affect the using creature, no one else
            {
                Creature recipient = space.creature;
                if (recipient.Name == "Bear")
                {
                    recipient.CurrAttack += 2;
                    recipient.CurrDefense += 2;
                    if (recipient.CurrAttack > recipient.BaseAttack + 2)
                        recipient.CurrAttack = recipient.BaseAttack + 2;
                    if (recipient.CurrDefense > recipient.BaseDefense + 2)
                        recipient.CurrDefense = recipient.BaseDefense + 2;
                }
            }
        }
    }
}
