using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Ash : Creature
    {
        public Ash(int level) : base(level)
        {
            Name = "Ash";
            Alignment = "Hero";
            Description = "A young spark plug of a writer with a zeal for life. Fast, frail, wields a katana.";

            if (level == 1)
            {
                MaxHP = 30;
                CurrHP = 30;
                MaxAP = 10;
                CurrAP = 10;
                BaseAttack = 12;
                CurrAttack = 12;
                BaseDefense = 6;
                CurrDefense = 6;
                TopMod = 1;
                FrontMod = 1;
                BottomMod = 1;
                Actions = 1;
                Abilities = new List<Ability>();
                Abilities.Add(new Overhead_Slash());
                Abilities.Add(new Wide_Swipe());
            }
        }
    }
}
