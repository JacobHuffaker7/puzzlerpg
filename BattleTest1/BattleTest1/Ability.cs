using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Ability
    {
        public string Title;
        public string Description;
        public int AP_Cost;
        public string TargetType;
        public Space[] Targets;
        public int BasePower;
        public bool top;
        public bool front;
        public bool bottom;

        public Ability(string title, string desc, int AP, string type, int BP, bool top, bool front, bool bottom)
        {
            Title = title;
            Description = desc;
            AP_Cost = AP;
            TargetType = type;
            //Targets will be set later by individual constructors or by a setter that's called externally;
            BasePower = BP;
            this.top = top;
            this.front = front;
            this.bottom = bottom;
        }

        public virtual void execute(Creature attacker)
        {
            foreach(Space space in Targets)
            {
                if(space.creature != null)
                {
                    Creature defender = space.creature;
                    defender.CurrHP -= calculateDamage(attacker, defender);
                    if(defender.CurrHP < 0)
                    {
                        defender.CurrHP = 0;
                    }
                }
            }
        }

        private int calculateDamage(Creature attacker, Creature defender)
        {
            int damage = BasePower + attacker.CurrAttack;
            if (top)
                damage = (int) (damage * defender.TopMod);
            if (front)
                damage = (int)(damage * defender.FrontMod);
            if (bottom)
                damage = (int)(damage * defender.BottomMod);

            return damage;
        }
    }
}
