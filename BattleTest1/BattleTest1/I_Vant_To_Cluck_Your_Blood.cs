using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class I_Vant_To_Cluck_Your_Blood : Ability
    {
        public I_Vant_To_Cluck_Your_Blood()
        {
            Title = "I Vant to Cluck Your Blood";
            Description = "The Vampire Chicken drains the blood of its enemies to heal itself.";
            AP_Cost = 10;
            TargetType = "Hero";
            //Targets will be set later by a setter that's called externally;
            Targets = new List<Space>();
            BasePower = 10;
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
                        attacker.CurrHP += damage/2;
                        if(attacker.CurrHP == attacker.MaxHP)
                        {
                            attacker.CurrHP = attacker.MaxHP;
                            Console.WriteLine(attacker.Name + " healed " + damage / 2 + "HP!");
                        }
                        Console.ReadLine();
                    }
                }
            }
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
