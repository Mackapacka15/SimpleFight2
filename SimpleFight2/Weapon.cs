using System;
using System.Collections.Generic;
using System.Text.Json;

namespace SimpleFight2
{
    public class Weapon
    {
        public string WeaponType { get; protected set; }
        protected int maxDmg { get; set; }
        protected int minDmg { get; set; }
        protected int hitChanse { get; set; }
        Random generator = new Random();

        public void Attack(Fighter f)
        {
            if (generator.Next(1, hitChanse + 1) == 1)
            {
                int dmg = generator.Next(minDmg, maxDmg + 1);
                f.hp -= dmg;
                Console.WriteLine(f.target.name + " used " + WeaponType + " and did " + dmg + " damage");
            }
            else
            {
                Console.WriteLine(f.target.name + " used " + WeaponType + " and missed!");
            }
        }
    }
}