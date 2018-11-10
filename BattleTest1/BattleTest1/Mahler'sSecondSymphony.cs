using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Mahler_sSecondSymphony : Ability
    {
        public Mahler_sSecondSymphony()
        {
            Title = "Mahler's 2nd Symphony";
            Description = "This sublime musical testimony of life after death revives a fallen friend with half their HP.";
            AP_Cost = 15;
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
                if(space.creature != null)
                {
                    Creature recipient = space.creature;
                    recipient.CurrHP = recipient.MaxHP / 2;
                    Console.WriteLine(attacker.Name + "uses " + Title + "! " + recipient.Name + "is revived with " + recipient.CurrHP + " HP!");
                    Console.ReadLine();
                }
            }
        }

        public override bool canDo(Creature attacker, Creature defender)
        {
            if (defender.CurrHP == 0)
                return true;
            else
                return false;
        }
    }
}
