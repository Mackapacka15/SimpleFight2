using System;
using System.Collections.Generic;
using System.Text.Json;

namespace SimpleFight2
{
    public class Weapon
    {
        public string WeaponType { get; init; }
        public int maxDmg { get; init; }
        public int minDmg { get; init; }
        public int hitChanse { get; init; }
        Random generator = new Random();

        public void Attack(Fighter f)
        {
            if (generator.Next(1, hitChanse + 1) == 1)
            {
                int dmg = generator.Next(minDmg, maxDmg + 1);
                dmg -= f.currentArmor.defense / 2;
                if (dmg <= 0)
                {
                    dmg = 1;
                }
                f.hp -= dmg;
                Console.WriteLine(f.target.name + " used " + WeaponType + " and did " + dmg + " damage");
            }
            else
            {
                Console.WriteLine(f.target.name + " used " + WeaponType + " and missed!");
            }
        }
        public void DisplayStats(int i)
        {
            Console.WriteLine(i + ") " + WeaponType);
            Console.WriteLine("     Max dmg " + maxDmg);
            Console.WriteLine("     Min dmg " + minDmg);
            Console.WriteLine("     Hit chanse 1/" + hitChanse);
        }
    }
}