using System;

namespace SimpleFight2
{
    public class Spear : Weapon
    {
        public Spear()
        {
            WeaponType = "Spear";
            maxDmg = 50;
            minDmg = 25;
            hitChanse = 2;
        }
    }
}