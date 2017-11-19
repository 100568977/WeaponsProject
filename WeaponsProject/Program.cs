using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsProject
{
    class Program
    {
        public static Random rand = new Random();
        static void Main(string[] args)
        {

            Enemy grunt = new Enemy();
            grunt.proximity = 5;

            Enemy mole = new Enemy();
            mole.proximity = 8;

            Enemy dingo = new Enemy();
            dingo.proximity = 12;


            Melee melee1 = new Melee();
            melee1.BaseDamage = 100;
            melee1.BaseRange = 10;
            melee1.CriticalDamage = melee1.BaseDamage * 2;

            for (int i = 0; i < 10; i++)
            {
            melee1.attack(grunt.proximity);
            melee1.attack(mole.proximity);
            melee1.attack(dingo.proximity);
            }


            Console.ReadKey();
        }
    }
}
