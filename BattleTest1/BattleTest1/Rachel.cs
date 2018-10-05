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
                Description = "";
                MaxHP = 0;
                CurrHP = 0;
                MaxAP = 0;
                CurrAP = 0;
                BaseAttack = 0;
                CurrAttack = 0;
                BaseDefense = 0;
                CurrDefense = 0;
                TopMod = 0;
                FrontMod = 0;
                BottomMod = 0;
                Actions = 0;
                Abilities = new List<Ability>();
                Abilities.Add(new Reading_Rainbow());
            }
        }
    }
}
