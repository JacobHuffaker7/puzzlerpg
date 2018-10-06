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
            battleOver = false;
            HeroSide = new Space[3];
            EnemySide = new Space[3];

            //EnemySide[0] = new Bear();
            //EnemySide[1] = new Turtle();
            //EnemySide[2] = new Skeleton();
        }
    }
}
