using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Steve : Creature
    {
        public Steve(int level) : base(level)
        {
            if (level == 1)
            {//Need description and stats
                Name = "Steve";
                Alignment = "Hero";
                Description = "A bassist who quietly supports his team with music.";
                MaxHP = 30;
                CurrHP = 30;
                MaxAP = 10;
                CurrAP = 10;
                BaseAttack = 8;
                CurrAttack = 8;
                BaseDefense = 8;
                CurrDefense = 8;
                TopMod = 1;
                FrontMod = 1;
                BottomMod = 1;
                Actions = 1;
                Abilities = new List<Ability>();
                Abilities.Add(new Bass_Bash());
                Abilities.Add(new Sick_Riff());
            }
        }
    }
}
