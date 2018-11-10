using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Turtle : Creature
    {
        public Turtle(int level) : base(level)
        {
            if(level == 1)
            {
                Name = "Turtle";
                Alignment = "Enemy";
                Description = "Good defenses, especially on the top, and a decent area attack. Also can heal allies. Weak to ground-based attacks.";
                MaxHP = 35;
                CurrHP = 35;
                MaxAP = 5;
                CurrAP = 5;
                BaseAttack = 8;
                CurrAttack = 8;
                BaseDefense = 9;
                CurrDefense = 9;
                TopMod = 0;
                FrontMod = 0.75;
                BottomMod = 2;
                Actions = 1;
                Abilities = new List<Ability>();
                Abilities.Add(new Water_Blast());
                Abilities.Add(new Misty_Heal());
            }
        }
    }
}
