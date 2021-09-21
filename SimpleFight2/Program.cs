using System;
using System.Collections.Generic;

namespace SimpleFight2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter enemy = new Fighter();
            Fighter player = new Fighter();
            List<Fighter> fighters = new List<Fighter>();
            enemy.target = player;
            player.target = enemy;
            player.playable = true;
            Console.WriteLine("Whats your hero's name?");
            player.name = Console.ReadLine();
            fighters.Add(player);
            fighters.Add(enemy);

            while (enemy.IsAlive() && player.IsAlive())
            {

                for (int i = 0; i <= fighters.Count - 1; i++)
                {
                    fighters[i].Attack();
                    fighters[i].target.Stats();
                }
                if (enemy.IsAlive() && player.IsAlive())
                {
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            if (!player.IsAlive() && !enemy.IsAlive())
            {
                Console.WriteLine("It's a draw");
            }
            else if (player.IsAlive())
            {
                Console.WriteLine(player.name + " won!!!");
            }
            else
            {
                Console.WriteLine(enemy.name + " won!!");
            }
            Console.ReadLine();

        }
    }
}
