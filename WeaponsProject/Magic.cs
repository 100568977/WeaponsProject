using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsProject
{
    public class Magic : Weapon, IDoesDamage
    {
        public void DoesDamage(float proximity)
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
