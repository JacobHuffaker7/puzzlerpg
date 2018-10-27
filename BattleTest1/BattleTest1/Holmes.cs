using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Holmes : Creature
    {
        public Holmes(int level) : base(level)
        {
            Name = "Holmes";
            Alignment = "Hero";
            Description = "A brilliant inventor with a chip on his shoulder.";

            if (level == 1)
            {
                MaxHP = 40;
                CurrHP = 40;
                MaxAP = 10;
                CurrAP = 10;
                BaseAttack = 8;
                CurrAttack = 8;
                BaseDefense = 10;
                CurrDefense = 10;
                TopMod = 1;
                FrontMod = 1;
                BottomMod = 0;
                Actions = 1;
                Abilities = new List<Ability>();
                Abilities.Add(new Wrench_Throw());
            }
        }
    }
}
