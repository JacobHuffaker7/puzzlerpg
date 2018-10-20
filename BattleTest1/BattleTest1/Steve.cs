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
                Description = "An underappreciated bassist who supports his team with music.";
                MaxHP = 30;
                CurrHP = 30;
                MaxAP = 20;
                CurrAP = 20;
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
                Abilities.Add(new Emo_Teen_Anthem());
                Abilities.Add(new Song_Of_Comfort());
                Abilities.Add(new Heavy_Metal());
                Abilities.Add(new Mahler_sSecondSymphony());
            }
        }
    }
}
