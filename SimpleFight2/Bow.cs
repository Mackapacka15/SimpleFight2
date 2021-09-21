using System;

namespace SimpleFight2
{
    public class Bow : Weapon
    {
        public Bow()
        {
            WeaponType = "Bow";
            maxDmg = 95;
            minDmg = 50;
            hitChanse = 3;
        }

    }
}