using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Bear : Creature
    {
        public Bear(int level) : base(level)
        {
            if(level == 1)
            {
                Name = "Bear";
                Alignment = "Enemy";
                Description = "A strong creature with tough, thick skin and deadly claws. Excels in close quarters.";
                MaxHP = 45;
                CurrHP = 45;
                MaxAP = 5;
                CurrAP = 5;//This is intended to give a little time before using its Bear Rage
                BaseAttack = 10;
                CurrAttack = 10;
                BaseDefense = 10;
                CurrDefense = 10;
                TopMod = 1;
                FrontMod = 1;
                BottomMod = 1;
                Actions = 1;
                Abilities = new List<Ability>();
                Abilities.Add(new Bear_Slash());
                Abilities.Add(new Bear_Rage());
            }
        }
    }
}
