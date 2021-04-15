using System;

namespace battleChallenge
{
    class Program
    {
        // Battle Game Challenge criteria
        // The hero and the monster will start with 10 health points.
        // All attacks will be a value between 1 and 10.
        // The hero will attack first.
        // Print the amount of health the monster lost and their remaining health.
        // If the monster's health is greater than 0, it can attack the hero.
        // Print the amount of health the hero lost and their remaining health.
        // Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
        // Print the winner.


        static void Main(string[] args)
        {
            int heroHealth = 10;
            int monsterHealth = 10;
            Random rnd = new Random();
            Console.WriteLine("The battle between the Hero and the Monster has begun!");
            Console.WriteLine("------------------------------------------------------\n");
            do
            {
                Console.WriteLine("The Hero attacked with the ancient battle axe!");
                int heroAttack = rnd.Next(1, 11);
                monsterHealth = monsterHealth - heroAttack;
                if(monsterHealth < 0)
                {
                    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and is dead!");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");
                    Console.WriteLine();
                }
                
                // is monster alive to attack
                if (monsterHealth > 0)
                {
                    Console.WriteLine("The Monster attacked with razor sharp claws!");
                    int monsterAttack = rnd.Next(1, 11);
                    heroHealth = heroHealth - monsterAttack;
                    if (heroHealth < 0)
                    {
                        Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and is dead!");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
                        Console.WriteLine();
                    }
                    
                }
            } while (heroHealth > 0 && monsterHealth > 0);

            if (heroHealth <= 0)
            {
                Console.WriteLine("The Monster Wins!");
            }
            else
            {
                Console.WriteLine("The Hero Wins!");
            }

            Console.WriteLine("\n\n");
            // Alternative Code Solution //
            //int hero = 10;
            //int monster = 10;

            //Random dice = new Random();

            //do
            //{
            //    int roll = dice.Next(1, 11);
            //    monster -= roll;
            //    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

            //    if (monster <= 0) continue;

            //    roll = dice.Next(1, 11);
            //    hero -= roll;
            //    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

            //} while (hero > 0 && monster > 0);

            //Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
        }
    }
}
