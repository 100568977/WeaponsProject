using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsProject
{
    public class Melee : Weapon
    {
        public override void attack(float proximity)
        {
            if (BaseRange >= proximity)
            {
                int randNumber = Program.rand.Next(100);
                int randNumber2 = Program.rand.Next(100);
                float meleeDamage = 0;
                string ifCrit = null;

                if (randNumber2 <= 2)
                {
                    meleeDamage = CriticalDamage;
                    ifCrit = "(critical)";
                }
                else
                {
                    meleeDamage = BaseDamage;
                }

                if (randNumber < 85)
                {
                    if ((BaseRange / 2) >= proximity)
                    { 
                        Console.WriteLine("You melee hit for " + (meleeDamage * 1.2) + ifCrit + " damage!");
                    }
                    else
                    {
                        Console.WriteLine("You melee hit for " + meleeDamage + ifCrit + " damage!");
                    }
                }
                else
                {
                    Console.WriteLine("The melee attack missed, it dodged your attack!");
                }                
            }
            else 
            {
                Console.WriteLine("The melee attack missed, you were too far out of range!");
            }            
        }
    }
}
