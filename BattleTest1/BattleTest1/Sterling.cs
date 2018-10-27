using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Sterling : Creature
    {
        public Sterling(int level) : base(level)
        {
            Name = "Sterling";
            Alignment = "Hero";
            Description = "A laid-back businessman and snack-distributor-in-chief.";

            if (level == 1)
            {
                MaxHP = 45;
                CurrHP = 45;
                MaxAP = 10;
                CurrAP = 10;
                BaseAttack = 6;
                CurrAttack = 6;
                BaseDefense = 13;
                CurrDefense = 13;
                TopMod = 1;
                FrontMod = 0;
                BottomMod = 1;
                Actions = 1;
                Abilities = new List<Ability>();
                Abilities.Add(new Fridge_Beam());
                Abilities.Add(new Pinka_Cola());
            }
        }
    }
}
