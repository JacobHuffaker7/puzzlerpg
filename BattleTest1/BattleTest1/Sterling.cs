﻿using System;
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
            if (level == 1)
            {//Need description and stats
                Name = "Sterling";
                Alignment = "Hero";
                Description = "A laid-back businessman and snack-distributor-in-chief.";
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
                //Abilities.Add(new Pinka_Cola());
            }
        }
    }
}
