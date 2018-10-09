using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Battle1 : Battle
    {
        public Battle1()
        {
            Rounds = 0;
            HeroSide = new Space[3];
            EnemySide = new Space[3];

            for(int i = 0; i < 3; i++)
            {
                HeroSide[i] = new Space();
                EnemySide[i] = new Space();
            }

            EnemySide[0].creature = new Holmes(1);
            EnemySide[1].creature = new Ash(1);
            EnemySide[2].creature = new Rachel(1);
        }
    }
}
