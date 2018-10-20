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
            Console.WriteLine("Choose a battle.");
            Console.WriteLine("Battle 1: Initial Test");
            while (Console.Read() != '1')
            {
                Console.WriteLine("Choose a battle.");
                Console.WriteLine("Battle 1: Initial Test");
            }
            new Battle1().runBattle();
        }
    }
}
