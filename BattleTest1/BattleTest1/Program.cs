using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Choose a battle.");
                Console.WriteLine("1: Initial Test");
                Console.WriteLine("2: Final Boss");

                int key = Console.Read();
                if (key == '1')
                    new Battle1().runBattle();
                else if (key == '2')
                    new FinalBattle().runBattle();
                else
                {
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
