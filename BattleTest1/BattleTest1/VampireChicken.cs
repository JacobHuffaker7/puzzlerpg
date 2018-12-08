using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class VampireChicken : Creature
    {
        public VampireChicken(int level) : base(level)
        {
            if (level == 1)
            {
                Name = "Vampire Chicken";
                Alignment = "Enemy";
                Description = "Truly the most fowl of monsters.";
                MaxHP = 100;
                CurrHP = 100;
                MaxAP = 5;
                CurrAP = 5;
                BaseAttack = 10;
                CurrAttack = 10;
                BaseDefense = 10;
                CurrDefense = 10;
                TopMod = 1;
                FrontMod = 1;
                BottomMod = 1;
                Actions = 1;
                Abilities = new List<Ability>();
                Abilities.Add(new I_Vant_To_Cluck_Your_Blood());
                Abilities.Add(new Cock_A_Doodle_Doom());
            }
        }
    }
}
