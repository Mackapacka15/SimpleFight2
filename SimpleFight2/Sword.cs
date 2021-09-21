using System;

namespace SimpleFight2
{
    public class Sword : Weapon
    {
        public Sword()
        {
            WeaponType = "Sword";
            maxDmg = 15;
            minDmg = 10;
            hitChanse = 1;
        }
    }
}