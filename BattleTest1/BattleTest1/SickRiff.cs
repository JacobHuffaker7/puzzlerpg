using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Sick_Riff : Ability
    {
        public Sick_Riff(string title, string desc, int AP, string type, int BP, bool top, bool front, bool bottom) 
            : base(title, desc, AP, type, BP, top, front, bottom)
        {
            
        }

        public override void execute(Creature attacker)
        {
            foreach(Space space in Targets)
            {
                Creature recipient = space.creature;
                if(recipient != null)
                {
                    recipient.CurrAttack *= 3;
                    recipient.CurrAttack /= 2;
                    if (recipient.CurrAttack > recipient.BaseAttack * 4)
                        recipient.CurrAttack = recipient.BaseAttack * 4;
                }
            }
        }
    }
}
