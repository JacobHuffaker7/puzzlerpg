using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Nick : Creature
    {
        public Nick(int level) : base(level)
        {
            if (level == 1)
            {//Need description and stats
                Name = "Nick";
                Alignment = "Hero";
                Description = "A conniving lawyer with a penchant for fighting dirty.";
                MaxHP = 35;
                CurrHP = 35;
                MaxAP = 10;
                CurrAP = 10;
                BaseAttack = 10;
                CurrAttack = 10;
                BaseDefense = 10;
                CurrDefense = 10;
                TopMod = 1;
                FrontMod = 1;
                BottomMod = 1;
                Actions = 1;
                Abilities = new List<Ability>();
                Abilities.Add(new Bicycle_Kick());
            }
        }
    }
}
