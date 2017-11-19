﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsProject
{
    public abstract class Weapon
    {
        public float BaseDamage;
        public float BaseRange;
        public float CriticalDamage;

        public void poke()
        {
            Console.WriteLine("You did 1 damage!");
        }

        public abstract void attack(float proximity);
    }
}
