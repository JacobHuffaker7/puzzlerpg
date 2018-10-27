using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Battle
    {
        public int Rounds;
        public bool win = false;
        public bool lose = false;
        public Space[] HeroSide;
        public Space[] EnemySide;

        public void runBattle()
        {
            chooseParty();
        }

        private void drawMap()
        {
            Console.Clear();
            Console.WriteLine();
            Console.Write("Enemies: ||");
            for (int i = 0; i < EnemySide.Length; i++)
            {
                Console.Write(" " + EnemySide[i].creature.Name + " (" + EnemySide[i].creature.CurrHP + "/" + EnemySide[i].creature.MaxHP + ") ||");
            }
            Console.WriteLine();
            Console.Write("Heroes:  ||");
            for (int i = 0; i < EnemySide.Length; i++)
            {
                Console.Write(" " + HeroSide[i].creature.Name + " (" + HeroSide[i].creature.CurrHP + "/" + HeroSide[i].creature.MaxHP + ") ||");
            }
            Console.Write("\n\n");
        }

        private int teamActionsLeft(Space[] side)
        {
            int a = 0;
            foreach(Space space in side)
            {
                if(space.creature != null)
                {
                    if (space.creature.Actions > 0 && space.creature.CurrHP > 0)
                        a++;
                }
            }
            return a;
        }

        private void chooseParty()
        {
            String[] HeroNames = new String[3];
            HeroNames[0] = "";
            HeroNames[1] = "";
            HeroNames[2] = "";
            int HeroIndex = 0;
            bool teamReady = false;
            while (!teamReady)
            {
                Console.Clear();
                Console.WriteLine();
                Console.Write("Enemies: ||");
                for(int i = 0; i < EnemySide.Length; i++)
                {
                    Console.Write(" " + EnemySide[i].creature.Name + " (" + EnemySide[i].creature.CurrHP + "/" + EnemySide[i].creature.MaxHP + ") ||");
                }
                Console.WriteLine();
                Console.WriteLine("Heroes:  || " + HeroNames[0] + " || " + HeroNames[1] + " || " + HeroNames[2] + " || \n");
                int key;
                while (HeroIndex == 3)
                {
                    Console.WriteLine("\nUse this party? Y/N");
                    key = Console.Read();
                    if (key == 'y')
                    {
                        teamReady = true;
                        break;                       
                    }
                    else if (key == 'n')
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            HeroSide[i].creature = null;
                            HeroNames[i] = "";
                        }
                        HeroIndex = 0;
                        teamReady = true;
                    }
                    else
                        continue;
                }
                if(teamReady)
                    break;

                Console.WriteLine("Add Heroes, left to right: 1.Ash 2.Holmes 3.Nick 4.Rachel 5.Sterling 6.Steve");
                key = Console.Read();
                if (key == '1' && !HeroNames.Contains("Ash"))
                {
                    HeroSide[HeroIndex].creature = new Ash(1);
                    HeroNames[HeroIndex] = "Ash";
                    HeroIndex++;
                }
                else if (key == '2' && !HeroNames.Contains("Holmes"))
                {
                    HeroSide[HeroIndex].creature = new Holmes(1);
                    HeroNames[HeroIndex] = "Holmes";
                    HeroIndex++;
                }
                else if (key == '3' && !HeroNames.Contains("Nick"))
                {
                    HeroSide[HeroIndex].creature = new Nick(1);
                    HeroNames[HeroIndex] = "Nick";
                    HeroIndex++;
                }
                else if (key == '4' && !HeroNames.Contains("Rachel"))
                {
                    HeroSide[HeroIndex].creature = new Rachel(1);
                    HeroNames[HeroIndex] = "Rachel";
                    HeroIndex++;
                }
                else if (key == '5' && !HeroNames.Contains("Sterling"))
                {
                    HeroSide[HeroIndex].creature = new Sterling(1);
                    HeroNames[HeroIndex] = "Sterling";
                    HeroIndex++;
                }
                else if (key == '6' && !HeroNames.Contains("Steve"))
                {
                    HeroSide[HeroIndex].creature = new Steve(1);
                    HeroNames[HeroIndex] = "Steve";
                    HeroIndex++;
                }
            }
            startBattle();
        }

        public bool allDead(Space[] grid)
        {
            bool done = true;
            foreach(Space space in grid)
            {
                if(space.creature != null)
                {
                    if (space.creature.CurrHP > 0)
                        done = false;
                }
            }
            return done;
        }

        private void startBattle()
        {
            //do Opening animations or whatever
            while (!win && !lose)
            {
                PlayerTurn();
                if (win || lose)
                    break;
                EnemyTurn();
                if (win || lose)
                    break;
                StatusTurn();
                if (allDead(HeroSide))
                    lose = true;
                else if (allDead(EnemySide))
                    win = true;
                else
                    Billable_Hours.elapsed++;
            }
            //do end battle stuff.
            if (win)
            {
                Console.Write("\n\nYou win!");
            }
            else if (lose)
            {
                Console.Write("\n\nYou lose.");
            }
            Console.ReadLine();
        }

        private void PlayerTurn()
        {
            foreach(Space space in HeroSide)
            {
                if(space.creature != null)
                {
                    space.creature.Actions = 1;
                }
            }

            while(teamActionsLeft(HeroSide) > 0)
            {
                if (allDead(HeroSide))
                {
                    lose = true;
                    return;
                }
                else if (allDead(EnemySide))
                {
                    win = true;
                    return;
                }
                //Draw map and menu.
                drawMap();
                Creature hero = null;
                for(int i = 0; i < HeroSide.Length; i++)
                {
                    if(HeroSide[i].creature != null)
                    {
                        hero = HeroSide[i].creature;
                        Console.Write("\t" + (i+1) + ". " + hero.Name);
                    }
                }
                Console.Write("\n");
                for (int i = 0; i < HeroSide.Length; i++)
                {
                    if (HeroSide[i].creature != null)
                    {
                        hero = HeroSide[i].creature;
                        Console.Write("\tHP: " + hero.CurrHP + "/" + hero.MaxHP);
                    }
                }
                Console.Write("\n");
                for (int i = 0; i < HeroSide.Length; i++)
                {
                    if (HeroSide[i].creature != null)
                    {
                        hero = HeroSide[i].creature;
                        Console.Write("\tAP: " + hero.CurrAP + "/" + hero.MaxAP);
                    }
                }
                Console.Write("\n");
                for (int i = 0; i < HeroSide.Length; i++)
                {
                    if (HeroSide[i].creature != null)
                    {
                        hero = HeroSide[i].creature;
                        Console.Write("\tActions: " + hero.Actions);
                    }
                }
                Console.Write("\n");

                Ability choice = null;
                Creature attacker = null;
                int key = Console.Read();
                if (key == '1')
                {
                    if (HeroSide[0].creature == null)
                        continue;
                    else if (HeroSide[0].creature.Actions == 0)
                    {
                        Console.WriteLine("No actions left for " + HeroSide[0].creature.Name + ".");
                        Console.ReadLine();
                        continue;
                    }
                    else if (HeroSide[0].creature.CurrHP == 0)
                    {
                        Console.WriteLine(HeroSide[0].creature.Name + "is out cold!");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        choice = displayAbilities(HeroSide[0].creature);
                        attacker = HeroSide[0].creature;
                    }
                }
                else if (key == '2')
                {
                    if (HeroSide[1].creature == null)
                        continue;
                    else if (HeroSide[1].creature.Actions == 0)
                    {
                        Console.WriteLine("No actions left for " + HeroSide[1].creature.Name + ".");
                        Console.ReadLine();
                        continue;
                    }
                    else if (HeroSide[1].creature.CurrHP == 0)
                    {
                        Console.WriteLine(HeroSide[1].creature.Name + "is out cold!");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        choice = displayAbilities(HeroSide[1].creature);
                        attacker = HeroSide[1].creature;
                    }
                }
                else if (key == '3')
                {
                    if (HeroSide[2].creature == null)
                        continue;
                    else if (HeroSide[2].creature.Actions == 0)
                    {
                        Console.WriteLine("No actions left for " + HeroSide[2].creature.Name + ".");
                        Console.ReadLine();
                        continue;
                    }
                    else if (HeroSide[2].creature.CurrHP == 0)
                    {
                        Console.WriteLine(HeroSide[2].creature.Name + "is out cold!");
                        Console.ReadLine();
                        continue;
                    }
                    else
                    {
                        choice = displayAbilities(HeroSide[2].creature);
                        attacker = HeroSide[2].creature;
                    }
                }
                else
                    continue;

                if(choice == null)
                {
                    attacker = null;
                    continue;
                }

                if (choice.TargetType == "Hero")
                {
                    if (!pickTarget(attacker, choice, HeroSide))
                        continue;
                }
                else if (choice.TargetType == "Enemy")
                {
                    if (!pickTarget(attacker, choice, EnemySide))
                        continue;
                }
                choice.execute(attacker);
                choice.Targets.Clear();
                attacker.Actions--;
                attacker.CurrAP -= choice.AP_Cost;
            }
        }

        //returns true if ability is executed and false if not.
        private bool pickTarget(Creature attacker, Ability choice, Space[] grid)
        {
            Space selected = null;
            while (selected == null)
            {
                drawMap();
                Console.WriteLine(attacker.Name + " will use " + choice.Title + " on...");
                for (int i = 0; i < grid.Length; i++)
                {
                    if (grid[i].creature != null)
                    {
                        Creature target = grid[i].creature;
                        Console.Write((i + 1) + "." + target.Name + " (" + target.CurrHP + "/" + target.MaxHP + ")\t");
                    }
                }
                Console.Write((grid.Length+1) + ". Cancel");

                Console.Write("\n");
                string line = Console.ReadLine();
                int x = -1;
                if (Int32.TryParse(line, out x))
                {
                    if (x == grid.Length + 1)
                        return false;
                    else if (x > 0 && x <= grid.Length)
                    {
                        if (grid[x - 1].creature != null)
                        {
                            if (choice.canDo(attacker, grid[x - 1].creature))
                            {
                                choice.setTargets(grid, x - 1);
                                selected = grid[x-1];
                            }
                        }
                    }
                }
            }
            return true;
        }

        private Ability displayAbilities(Creature hero)
        {
            Ability choice = null;
            while (choice == null)
            {
                drawMap();
                Console.WriteLine(hero.Name + " (" + hero.CurrAP + "/" + hero.MaxAP + " AP)");
                for (int i = 0; i < hero.Abilities.Count; i++)
                {
                    Ability option = hero.Abilities[i];
                    Console.WriteLine((i+1) + ". " + option.Title + "(" + option.AP_Cost + " AP): " + option.Description);
                }
                Console.Write((hero.Abilities.Count + 1) + ". Cancel\n");

                string line = Console.ReadLine();
                int x = -1;
                if (Int32.TryParse(line, out x))
                {
                    if (x == hero.Abilities.Count + 1)
                        return null;
                    else if (x > 0 && x <= hero.Abilities.Count)
                    {
                        if (hero.Abilities[x - 1].AP_Cost > hero.CurrAP)
                        {
                            Console.WriteLine("\n" + hero.Name + " doesn't have enough AP.");
                            Console.ReadLine();
                            continue;
                        }
                        choice = hero.Abilities[x - 1];
                    }
                }
            }
            return choice;
        }

        public void EnemyTurn()
        {
            Random random = new Random();
            foreach(Space space in EnemySide)
            {
                if (allDead(HeroSide))
                {
                    lose = true;
                    return;
                }
                else if (allDead(EnemySide))
                {
                    win = true;
                    return;
                }
                Creature enemy = space.creature;
                if (enemy != null)
                {
                    if (enemy.CurrHP > 0)
                    {
                        Ability chosenAbility = null;
                        while (chosenAbility == null)
                        {
                            int r = random.Next(enemy.Abilities.Count);
                            if (enemy.CurrAP >= enemy.Abilities[r].AP_Cost)
                                chosenAbility = enemy.Abilities[r];
                        }

                        /*TODO: In the future, we'll want to check if the ability should
                         * hit heroes or enemies, and make sure the target is valid (i.e.,
                         * you shouldn't be able to heal or hurt anyone who has 0 HP.)
                         * This would also let us add healing abilities for the enemies
                         * to use. Maybe each ability could have a canDo() function to
                         * check if the move is valid, given the attacker and targets.
                         * For now, we'll assume all the enemies can do is attack heroes.
                        */
                        int index = -1;

                        while (index < 0)
                        {
                            index = random.Next(HeroSide.Length);
                            {
                                if (HeroSide[index].creature != null)
                                {
                                    if (HeroSide[index].creature.CurrHP > 0)
                                    {
                                        chosenAbility.setTargets(HeroSide, index);
                                    }
                                    else index = -1;
                                }
                                else index = -1;
                            }
                        }

                        chosenAbility.execute(enemy);
                        chosenAbility.Targets.Clear();
                    }
                }
            }
        }

        public void StatusTurn()
        {

        }
    }
}
