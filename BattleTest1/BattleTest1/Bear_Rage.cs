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
            Description = "Enraged through battle, it increases its attack and defense.";
            AP_Cost = 5;
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
            return;
        }

        public override void execute(Creature attacker)
        {
            attacker.CurrAttack += 2;
            attacker.CurrDefense += 2;

            Console.WriteLine("The bear rages! Its attack and defense increase!");
            if (attacker.CurrAttack > attacker.BaseAttack + 2)
                attacker.CurrAttack = attacker.BaseAttack + 2;
            if (attacker.CurrDefense > attacker.BaseDefense + 2)
                attacker.CurrDefense = attacker.BaseDefense + 2;
            
        }
    }
}
