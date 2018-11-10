using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Creature
    {
        public string Name;
        public string Alignment; //Which side the creature is on. Either "Hero" or "Enemy".
        public string Description;
        public int MaxHP;
        public int CurrHP;
        public int MaxAP;
        public int CurrAP;
        public int BaseAttack;
        public int CurrAttack;
        public int BaseDefense;
        public int CurrDefense;
        public double TopMod; //These three doubles modify damage received from the top, front, and bottom.
        public double FrontMod;
        public double BottomMod;
        public int Actions;
        public List<Ability> Abilities;

        //This is the basic template of a Creature constructor. The derived classes will override it in every case.
        public Creature(int level)
        {
            //Name = name;
            //Alignment = align;
            //Description = desc;
            //MaxHP = HP;
            //CurrHP = HP;
            //MaxAP = AP;
            //CurrAP = AP;
            //BaseAttack = Attack;
            //CurrAttack = Attack;
            //BaseDefense = Defense;
            //CurrDefense = Defense;
            //TopMod = top;
            //FrontMod = front;
            //BottomMod = bottom;
            //Actions = 1;
            //Abilities = new List<Ability>();
        }
    }
}
