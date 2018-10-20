using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Space
    {
        public Creature creature;
        public List<Hazard> hazards;

        public Space()
        {
            creature = null;
            hazards = new List<Hazard>();
        }
    }
}
