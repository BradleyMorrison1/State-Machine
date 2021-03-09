using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State_Machine
{
    class Program
    {
        enum Weapons
        {
            pistol,
            shotgun,
            smg,
            ar,
            sniper
        }

        static Weapons weapon;

        static void Main(string[] args)
        {
            Console.WriteLine("State Machine | Bradley Morrison");
            Console.WriteLine();

            Weapons weapon;


            // simulated gameplay

            ChangeWeapon(Weapons.ar);

            FireWeapon();

            Console.ReadKey(true);
        }

        static void ChangeWeapon(Weapons newWeapon)
        {
            weapon = newWeapon;
        }

        static void FireWeapon()
        {
            switch(weapon)
            {
                case Weapons.pistol:
                    Console.WriteLine("Pistol fired!");
                    break;

                case Weapons.shotgun:
                    Console.WriteLine("Shotgun fired!");
                    break;

                case Weapons.smg:
                    Console.WriteLine("Submachine Gun fired!");
                    break;

                case Weapons.ar:
                    Console.WriteLine("Assault Rifle fired!");
                    break;

                case Weapons.sniper:
                    Console.WriteLine("Sniper fired!");
                    break;
            }
        }
    }
}
