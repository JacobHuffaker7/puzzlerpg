using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Rachel : Creature
    {
        public Rachel(int level) : base(level)
        {
            if (level == 1)
            {//Need description and stats
                Name = "Rachel";
                Alignment = "Hero";
                Description = "A hardworking editor who fights with the power of literature.";
                MaxHP = 35;
                CurrHP = 35;
                MaxAP = 10;
                CurrAP = 10;
                BaseAttack = 9;
                CurrAttack = 9;
                BaseDefense = 9;
                CurrDefense = 9;
                TopMod = 1;
                FrontMod = 1;
                BottomMod = 1;
                Actions = 1;
                Abilities = new List<Ability>();
                Abilities.Add(new Reading_Rainbow());
                Abilities.Add(new For_Whom_The_Bell_Tolls());
            }
        }
    }
}
