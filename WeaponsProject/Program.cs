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

            Enemy archer = new Enemy();
            archer.proximity = 600;


            Melee melee1 = new Melee();
            melee1.BaseDamage = 100;
            melee1.BaseRange = 10;
            melee1.CriticalDamage = melee1.BaseDamage * 2;

            Ranged ranged1 = new Ranged();
            ranged1.BaseDamage = 30;
            ranged1.BaseRange = 500;
            ranged1.CloseRange = 200;
            ranged1.CriticalDamage = ranged1.BaseDamage * 2;

            Magic magic1 = new Magic();
            magic1.BaseDamage = 20;
            magic1.BaseRange = 200;

          
            for (int i = 0; i < 10; i ++)
            {
            melee1.DoesDamage(grunt.proximity);
            melee1.DoesDamage(mole.proximity);
            melee1.DoesDamage(dingo.proximity);
            }

            for (int i = 0; i < 30; i++)
            {
                ranged1.DoesDamage(archer.proximity);
            } 
            

            magic1.DoesDamage(dingo.proximity);
            magic1.DoesDamage(archer.proximity);
            Console.ReadKey();
        }
    }
}
