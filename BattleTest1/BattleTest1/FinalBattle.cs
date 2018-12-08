using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class FinalBattle : Battle
    {
        public FinalBattle()
        {
            Rounds = 0;
            HeroSide = new Space[3];
            EnemySide = new Space[1];

            for (int i = 0; i < 3; i++)
            {
                HeroSide[i] = new Space();
            }

            EnemySide[0] = new Space();
            EnemySide[0].creature = new VampireChicken(1);
        }

        public new void EnemyTurn()
        {
            Random random = new Random();
            Creature vamp = EnemySide[0].creature;
            if (vamp != null)
            {

                Ability chosenAbility = null;
                if (Rounds % 10 == 0)
                    chosenAbility = vamp.Abilities[1];
                else
                    chosenAbility = vamp.Abilities[0];

                int index = -1;

                Space[] side = new Space[3];
                if (chosenAbility.TargetType == "Hero")
                    HeroSide.CopyTo(side, 0);
                else if (chosenAbility.TargetType == "Enemy")
                    EnemySide.CopyTo(side, 0);
                while (index < 0)
                {
                    index = random.Next(side.Length);
                    {
                        if (side[index].creature != null)
                        {
                            if (side[index].creature.CurrHP > 0)
                            {
                                chosenAbility.setTargets(side, index);
                            }
                            else index = -1;
                        }
                        else index = -1;
                    }
                }

                int open = random.Next(3);
                if(open == 0)
                {
                    vamp.TopMod = 1;
                    vamp.FrontMod = 0;
                    vamp.BottomMod = 0;
                    Console.WriteLine("Vampire Chicken pokes its head out of the top of the eggshell.");
                    Console.ReadLine();
                }
                else if (open == 1)
                {
                    vamp.TopMod = 0;
                    vamp.FrontMod = 1;
                    vamp.BottomMod = 0;
                    Console.WriteLine("Vampire Chicken pokes its head out of a hole in the front of the shell.");
                    Console.ReadLine();
                }
                else if (open == 1)
                {
                    vamp.TopMod = 0;
                    vamp.FrontMod = 0;
                    vamp.BottomMod = 1;
                    Console.WriteLine("Vampire Chicken hangs upside down like a bat. His head touches the floor.");
                    Console.ReadLine();
                }

                chosenAbility.execute(vamp);
                chosenAbility.Targets.Clear();
            }
        }
    }
}
