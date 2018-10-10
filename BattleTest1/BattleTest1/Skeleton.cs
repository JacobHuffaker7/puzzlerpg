using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Skeleton : Creature
    {
        public Skeleton(int level) : base(level)
        {
            if(level == 1)
            {
                Name = "Skeleton";
                Alignment = "Enemy";
                Description = "Weak defences and HP, but has long ranged attacks.";
                MaxHP = 25;
                CurrHP = 25;
                MaxAP = 3;
                CurrAP = 3;
                BaseAttack = 9;
                CurrAttack = 9;
                BaseDefense = 6;
                CurrDefense = 6;
                TopMod = 1.1;
                FrontMod = 1.1;
                BottomMod = 1.1;
                Actions = 1;
                Abilities = new List<Ability>();
                Abilities.Add(new Arrow_Shot());
                Abilities.Add(new Piercing_Shot());
            }
        }
    }
}
