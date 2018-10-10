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
        public List<Space> Targets;
        public int BasePower;
        public bool top;
        public bool front;
        public bool bottom;

        public Ability()
        {
            
        }

        public virtual void execute(Creature attacker)
        {
            foreach(Space space in Targets)
            {
                if (space.creature != null)
                {
                    Creature defender = space.creature;
                    if(defender.CurrHP > 0)
                    { 
                        int damage = calculateDamage(attacker, defender);
                        defender.CurrHP -= damage;
                        Console.WriteLine(attacker.Name + " uses " + Title + " on " + defender.Name + " for " + damage + " damage!");
                        if (defender.CurrHP <= 0)
                        {
                            defender.CurrHP = 0;
                            Console.WriteLine(defender.Name + " is out cold!");
                        }
                        Console.ReadLine();
                    }
                }
            }
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
                damage = (int) (damage * defender.TopMod);
            if (front)
                damage = (int)(damage * defender.FrontMod);
            if (bottom)
                damage = (int)(damage * defender.BottomMod);

            return damage;
        }

        public virtual bool canDo(Creature attacker, Creature defender)
        {
            if (defender.CurrHP == 0)
                return false;
            else
                return true;
        }
    }
}
