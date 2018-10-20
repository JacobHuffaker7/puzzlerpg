using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Hazard
    {
        public string Title;
        public List<Space> Targets;
        public int rounds;
        public int BasePower;
        public bool top;
        public bool front;
        public bool bottom;

        public Hazard()
        {

        }

        public virtual void execute()
        {

        }

        //default setTargets only adds the space selected.
        public virtual void setTargets(Space[] grid, int index)
        {
            Targets.Add(grid[index]);
        }

        private int calculateDamage(Creature attacker, Creature defender)
        {
            int damage = (BasePower + attacker.CurrAttack) - defender.CurrDefense;
            if (damage <= 0)
                return 0;
            if (top)
                damage = (int)(damage * defender.TopMod);
            if (front)
                damage = (int)(damage * defender.FrontMod);
            if (bottom)
                damage = (int)(damage * defender.BottomMod);

            return damage;
        }
    }
}
