using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponsProject
{
    public class Ranged : Weapon
    {
        public int CloseRange;
        public override void attack(float proximity)
        {
            int randNumber = Program.rand.Next(100);
            decimal randNumber2 = (Program.rand.Next(50) + 50);
            int randNumber3 = Program.rand.Next(100);
            if (randNumber <= 75)
            {
                if (proximity >= CloseRange)
                {
                    if (randNumber <= (75 - (((proximity - BaseRange) / 10) * 2)))
                    {
                        if (proximity.Equals(CloseRange))
                        {
                            if (randNumber3 <= 2)
                            {
                                Console.WriteLine("You ranged hit for " + (CriticalDamage) + " damage!");
                            }
                            else
                            {
                                Console.WriteLine("You ranged hit for " + (BaseDamage) + " damage!");
                            }
                        }
                        else
                        {
                            if (randNumber3 <= 1)
                            {
                                Console.WriteLine("You ranged hit for " + (Convert.ToDecimal(CriticalDamage) * (randNumber2 / 100)) + " damage!");
                            }
                            else
                            {
                                Console.WriteLine("You ranged hit for " + (Convert.ToDecimal(BaseDamage) * (randNumber2 / 100)) + " damage!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You missed the ranged attack, try moving a bit closer!");
                    }
                }
                else
                {
                    Console.WriteLine("You missed the ranged attack, try moving a bit further away!");
                }
            }
            else
            {
                Console.WriteLine("You missed the ranged attack, just a bit unlucky!");
            }
        }
    }
}
