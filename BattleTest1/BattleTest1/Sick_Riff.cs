using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Sick_Riff : Ability
    {
        public Sick_Riff() 
        {
            Title = "Sick Riff";
            Description = "A sick bass riff that fires up an ally to boost their Attack.";
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
                    recipient.CurrAttack += recipient.BaseAttack / 2;
                    if (recipient.CurrAttack >= recipient.BaseAttack * 4)
                    {
                        recipient.CurrAttack = recipient.BaseAttack * 4;
                        Console.WriteLine(attacker.Name + " uses " + Title + "! " + recipient.Name + "'s attack is maxed!");
                        Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine(attacker.Name + " uses " + Title + "! " + recipient.Name + "'s attack rises!");
                    Console.ReadLine();
                }
            }
        }

    }
}
