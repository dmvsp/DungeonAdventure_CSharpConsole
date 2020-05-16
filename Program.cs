// Simple text dungeon crawler game
// Inspired by https://www.youtube.com/watch?v=EpB9u4ItOYU
// coded by Dmitry Sinelnikov (https://github.com/sinelnikovdm)
// 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonAdventure_CSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //System variables
            Random rand = new Random();

            //Game variables
            String[] enemies = { "Skeleton", "Zombie", "Warrior", "Assasin" };
            int maxEnemyHealth = 75;
            int enemyAttackDamage = 25;

            //Player Variables
            int health = 100;
            int attackDamage = 50;
            int numHealthPotions = 3;
            int healthPotionHealthAmount = 30;
            int HealthPotionDropChance = 50; //Percentage

            bool running = true;

            Console.WriteLine("Welcome to the Dungeon Adventure !");

            while (running)
            {
                Console.WriteLine("--------------------------------------------------------");

                int enemyHealth = rand.Next(maxEnemyHealth);
                String enemy = enemies[rand.Next(enemies.Length)];
                Console.WriteLine("\t#  " + enemy + " appeared # !\n");

                while (enemyHealth > 0 || health < 1 )
                {
                    Console.WriteLine("\tYour HP: " + health.ToString());
                    Console.WriteLine("\t" + enemy + "'s HP:" + enemyHealth.ToString());
                    Console.WriteLine("\n\tWhat you like to do ?");
                    Console.WriteLine("\t1. Attack");
                    Console.WriteLine("\t2. Drink health potion");
                    Console.WriteLine("\t3. Run !");

                    Console.WriteLine("");

                    Console.Write(">");

                    var input = Console.ReadKey();

                    switch (input.KeyChar)
                    {
                        case '1':
                            int damageDealt = rand.Next(attackDamage);
                            int damageTaken = rand.Next(enemyAttackDamage);

                            enemyHealth -= damageDealt;
                            health -= damageTaken;

                            Console.WriteLine("\t> You strike the " + enemy + " for " + damageDealt + " damage.");
                            Console.WriteLine("\t> You receive  " + damageTaken + " in retaliation.");

                            if (health < 1)
                            {
                                Console.WriteLine("\t> You have taken too much damage, you are too weak to go on ! ");
                                break;
                            }

                            break;

                        case '2':
                            if (numHealthPotions > 0)
                            {
                                health += healthPotionHealthAmount;
                                numHealthPotions--;

                                if (health > 100) {
                                    health = 100;
                                }

                                Console.WriteLine("\t> You drink a health potion, healing youself for " + healthPotionHealthAmount + ".");
                                Console.WriteLine("\t> You now have " + health + " HP.");
                                Console.WriteLine("\t> You have " + numHealthPotions + " left.");
                            }
                            else
                            {
                                Console.WriteLine("\t> You have no health potions left! Defeat enemies for a chance to get one !");
                            }

                            break;

                        case '3':
                            Console.WriteLine("\tYou run away from the " + enemy + "!");
                            enemyHealth = 0;
                            continue;

                        default:
                            Console.WriteLine("");
                            Console.WriteLine("\tBad input ! (Press 1,2 or 3 to continue)");
                            break;
                    }

                    if (enemyHealth < 1)
                    {
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine(" # " + enemy + " was defeated! # ");
                        Console.WriteLine(" # You have " + health + " HP left. # ");

                        if (rand.Next(100) < HealthPotionDropChance)
                        {
                            numHealthPotions++;

                            Console.WriteLine(" # The " + enemy + " dropped a health potion ! #");
                            Console.WriteLine(" # Now you have " + numHealthPotions + " health potion(s). #");
                            Console.WriteLine("");
                        }
                    }
                } // while (enemyHealth > 0)

                if (health < 1)
                {
                    Console.WriteLine("You limp out of the dungeon, weak from battle. Thank for playing ! ");
                    break;
                }

                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("What you like to do now ?");
                    Console.WriteLine("1. Continue fighting");
                    Console.WriteLine("2. Exit dungeon");

                    var input2 = Console.ReadKey();

                    if (input2.KeyChar == '1') {
                        Console.WriteLine("You continue on your adventure !");
                    }
                    else {
                        Console.WriteLine("You exit the dungeon, successful from your adventures ! Thank you for playing !");
                        running = false;
                    }                
            } //while (running)

            Console.ReadKey();
        }
    }
}
