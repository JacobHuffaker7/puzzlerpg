using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Piercing_Shot : Ability
    {
        public Piercing_Shot()
        {
            Title = "Piercing Shot";
            Description = "Skeleton shoots an arrow that pierces an enemies defense.";
            AP_Cost = 2;
            TargetType = "Hero";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 1;
            top = false;
            front = true;
            bottom = false;
        }

        public override void execute(Creature attacker)
        {
            foreach (Space space in Targets)
            {
                if (space.creature != null)
                {
                    Creature defender = space.creature;
                    if (defender.CurrHP > 0)
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

        private int calculateDamage(Creature attacker, Creature defender)
        {
            int damage = (BasePower + attacker.CurrAttack);
            if (damage <= 0)
                return 0;

            return damage;
        }
    }
}
