using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Emo_Teen_Anthem : Ability
    {
        public Emo_Teen_Anthem()
        {
            Title = "Emo Teen Anthem";
            Description = "Tones of teen angst make the target defensive.";
            AP_Cost = 2;
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
                    recipient.CurrDefense *= 3;
                    recipient.CurrDefense /= 2;
                    if (recipient.CurrDefense > recipient.BaseDefense * 4)
                        recipient.CurrDefense = recipient.BaseDefense * 4;
                }
            }
        }
    }
}
