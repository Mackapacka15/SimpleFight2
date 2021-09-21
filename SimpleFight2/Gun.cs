using System;

namespace SimpleFight2
{
    public class Gun : Weapon
    {
        public Gun()
        {
            WeaponType = "Gun";
            maxDmg = 100;
            minDmg = 90;
            hitChanse = 5;
        }
    }
}