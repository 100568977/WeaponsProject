using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsProject
{
    public class Magic : Weapon
    {
        public override void attack(float proximity)
        {
            if (proximity <= BaseRange)
            {
                Console.WriteLine("You hit the target for " + BaseDamage + " magic damage!");
            }
            else
            {
                Console.WriteLine("You missed the targer, reposition yourself!");
            }
        }
    }
}
