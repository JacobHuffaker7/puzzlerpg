using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Pinka_Cola : Ability
    {
        public Pinka_Cola()
        {
            Title = "Pinka Cola";
            Description = "A refreshing South American beverage that heals 10 HP.";
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
            foreach(Space space in Targets)
            {
                Creature recipient = space.creature;
                if(recipient != null)
                {
                    recipient.CurrHP += 10;
                    if (recipient.CurrHP > recipient.MaxHP)
                        recipient.CurrHP = recipient.MaxHP;
                    Console.WriteLine(attacker.Name + " uses " + Title + " on " + recipient.Name + " to heal 10 HP!");
                    Console.ReadLine();
                }
            }
        }
    }
}
