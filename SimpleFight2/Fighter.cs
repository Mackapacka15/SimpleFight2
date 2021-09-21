using System.Collections.Generic;
using System;

namespace SimpleFight2
{
    public class Fighter
    {
        public bool playable = false;
        public string name = "";
        public int hp = 100;

        public Weapon weapon = new Weapon();
        public List<Weapon> weapons = new List<Weapon>();

        public Fighter target;

        private Random generator = new Random();

        public Fighter()
        {
            weapons.Add(new Sword());
            weapons.Add(new Bow());
            weapons.Add(new Spear());
            weapons.Add(new Gun());

            string[] names = { "Dr. Doofenshmirtz", "The Joker", "Scarecrow" };
            name = names[generator.Next(0, 3)];
        }
        public void Attack()
        {
            if (playable)
            {
                string answer;
                int answer2;
                Console.WriteLine("What weapon do you want to use?");
                for (int i = 0; i < weapons.Count; i++)
                {
                    Console.WriteLine(i + ")" + weapons[i].WeaponType);
                }
                answer = Console.ReadLine();


                bool result = int.TryParse(answer, out answer2);
                if (result && answer2 <= weapons.Count - 1)
                {
                    weapons[answer2].Attack(target);
                }
                else
                {
                    Console.WriteLine("That wasn't a valid number. You get a random number!");
                    weapons[generator.Next(0, weapons.Count)].Attack(target);
                }
            }
            else
            {

                weapons[generator.Next(0, weapons.Count)].Attack(target);
            }

        }

        public bool IsAlive()
        {
            if (hp <= 0)
            {
                hp = 0;
                return false;
            }
            return true;
        }
        public void Stats()
        {
            IsAlive();
            Console.WriteLine(name + ":");
            Console.WriteLine(hp);
        }

    }
}