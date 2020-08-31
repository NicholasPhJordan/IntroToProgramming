using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            bool gameOver = false;
            while (gameOver == false)
            {
                //Decides the color of the text
                Console.ForegroundColor = ConsoleColor.Green;

                //This variable is used to deciede health and death 
                float health = 100.0f;
                if (health <= 0.0f)
                {
                    gameOver = true;
                    Console.WriteLine("You Died");
                    Console.WriteLine("G A M E  O V E R");
                }

                //This value is used to heal the player
                float healthRegen = 20.0f;

                //Decides damage
                float damage = 20.0f;

                //Character level Info
                bool maxLevelReached = false;
                int maxLevel = 100;
                int level = 1;

                //stores players role
                string role = "Adventurer";

                //decides the area the player is in
                string area = " ";

                //Introduction -- Player chooses name and role
                Console.WriteLine("Hello traveler! What is your name?");
                string name = Console.ReadLine();
                Console.WriteLine("Welcome " + name + "! " + "Please select a Role!");

                //shows list of roles for player to choose from and decides stats based on role
                List<string> roles = new List<string> { "Press 1 for Wizard", "Press 2 for Knight", "Press 3 for Rogue" };
                roles.ForEach(Console.WriteLine);
                char input = ' ';
                Console.WriteLine();
                while (input != '1' && input != '2' && input != '3')
                {
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        role = "Wizard";
                        health = 60.0f;
                        damage = 20.0f;
                        Console.Clear();
                        break;
                    }
                    else if (input == '2')
                    {
                        role = "Knight";
                        health = 100.0f;
                        damage = 10.0f;
                        Console.Clear();
                        break;
                    }
                    else if (input == '3')
                    {
                        role = "Rogue";
                        health = 80.0f;
                        damage = 15.0f;
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid input.");
                        continue;
                    }
                }

                //Confirms character info and adds func charStats to call the character stats
                void charStats(string name, string role, int level, float health, float damage)
                {
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Role: " + role);
                    Console.WriteLine("Level: " + level);
                    Console.WriteLine("Health: " + health);
                    Console.WriteLine("Damage: " + damage);
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                Console.WriteLine("Nice to meet you " + name + ". " + "The Mighty " + role + ".");
                Console.WriteLine("This is you...");
                charStats(name, role, level, health, damage);

                //Intro
                Console.WriteLine("You are a mighty adventurer in unknown lands where monsters, theives, and many other dangers live. " +
                    "But there is also untold treasure and glory hidden on the path ahead. Like many adventurers before you, you take on the deadly task of exploring " +
                    "these unknown lands. Good Luck!");

                //Continues Adventure
                //Console.WriteLine("You continue your adventure.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();

                //First Interaction
                Console.WriteLine("You begin your walk and run into a little girl in a little red hood. " +
                    "She looks up at you and smiles. Holding out her basket, she offers you an apple");
                Console.WriteLine("Press 1 to question her");
                Console.WriteLine("Press 2 to take an apple");
                Console.WriteLine("Press 3 to attack");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    Console.WriteLine("\nYou ask the little girl, why she is in these dangerous lands.");
                    Console.WriteLine("She doesn't say anything, but holds the basket up higher for you to take an apple.");
                    Console.WriteLine("Press 1 to take apple");
                    Console.WriteLine("Press 2 to walk away");
                    Console.WriteLine("Press 3 to attack");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        Console.WriteLine("\nYou take an apple from the little girl and eat it.");
                        Console.WriteLine("The little girl smiles with large fang like teeth. She pulls off the little red hood and turns into a large wolf!");
                        Console.WriteLine("Press 1 to run away");
                        Console.WriteLine("Press 2 to attack");
                        input = Console.ReadKey().KeyChar;
                        if (input == '1')
                        {
                            Console.WriteLine("\nYou manage to get away, but not before the wolf attacks you.");
                            Console.WriteLine("Loose 20 Health");
                            health -= 20;
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            if (role == "Wizard")
                            {
                                Console.WriteLine("\nYou cast a fireball at the wolf, frightening the wolf and causing the wolf to run away.");
                                Console.WriteLine("You continue your adventure.");
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (role == "Knight")
                            {
                                Console.WriteLine("\nYou swipe skillfully with your sword at the wolf, fightening the wolf and causing the wolf to run away.");
                                Console.WriteLine("You continue your adventure.");
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (role == "Rogue")
                            {
                                Console.WriteLine("\nYou quickly stab at the wolf, frightening the wolf and causing the wolf to run away.");
                                Console.WriteLine("You continue your adventure.");
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid Input");
                            }
                        }
                    }
                    else if (input == '2')
                    {
                        Console.WriteLine("\nYou walk away from the little girl.");
                        Console.WriteLine("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (input == '3')
                    {
                        if (role == "Wizard")
                        {
                            Console.WriteLine("\nYou cast a fireball at the wolf, frightening the wolf and causing the wolf to run away.");
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Knight")
                        {
                            Console.WriteLine("\nYou swipe skillfully with your sword at the wolf, fightening the wolf and causing the wolf to run away.");
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Rogue")
                        {
                            Console.WriteLine("\nYou quickly stab at the wolf, frightening the wolf and causing the wolf to run away.");
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input");
                    }
                }
                else if (input == '2')
                {
                    Console.WriteLine("\nYou take an apple from the little girl and eat it.");
                    Console.WriteLine("The little girl smiles with large fang like teeth. She pulls off the little red hood and turns into a large wolf!");
                    Console.WriteLine("Press 1 to run away");
                    Console.WriteLine("Press 2 to attack");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        Console.WriteLine("\nYou manage to get away, but not before the wolf attacks you.");
                        Console.WriteLine("Loose 20 Health");
                        health -= 20.0f;
                        Console.WriteLine("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (input == '2')
                    {
                        if (role == "Wizard")
                        {
                            Console.WriteLine("\nYou cast a fireball at the wolf, frightening the wolf and causing the wolf to run away.");
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Knight")
                        {
                            Console.WriteLine("\nYou swipe skillfully with your sword at the wolf, fightening the wolf and causing the wolf to run away.");
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Rogue")
                        {
                            Console.WriteLine("\nYou quickly stab at the wolf, frightening the wolf and causing the wolf to run away.");
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input");
                    }
                }
                else if (input == '3')
                {
                    if (role == "Wizard")
                    {
                        Console.WriteLine("\nYou cast a fireball at the girl, she throws off the hood, turns into a wolf, and runs away.");
                        Console.WriteLine("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (role == "Knight")
                    {
                        Console.WriteLine("\nYou swipe skillfully with your sword at the girl, she throws off the hood, turns into a wolf, and runs away.");
                        Console.WriteLine("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (role == "Rogue")
                    {
                        Console.WriteLine("\nYou quickly stab at the girl, she throws off the hood, turns into a wolf, and runs away.");
                        Console.WriteLine("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Input");
                }

                //Path Diverges
                Console.WriteLine("You continue walking down the path when you come to a fork in the road.");
                Console.WriteLine("Press 1 to go left towads a Tall Grassy Meadow.");
                Console.WriteLine("Press 2 to go right towards a Dark Woods.");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    Console.WriteLine("\nYou decide to walk towards the Tall Grassy Meadow and continue your adventure.");
                    area = "Tall Grassy Meadow";
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == '2')
                {
                    Console.WriteLine("\nYou decide to walk towards the Dark Woods and continue your adventure");
                    area = "Dark Woods";
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

                //code for Dark Woods area
                while (area == "Dark Woods")
                {
                    Console.WriteLine("You walk along the dark covered path and see an old man sitting on a fallen tree off the side of the road.");
                    Console.WriteLine("He looks up at you and asks you to help him up.");
                    Console.WriteLine("Press 1 to help him up");
                    Console.WriteLine("Press 2 to ignore and walk away");
                    Console.WriteLine("Press 3 to attack");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        Console.WriteLine("\nYou help up the old man and see his faded eyes realizing he is blind.");
                        Console.WriteLine("He thanks you for your help and waves his hand over your weapon. " +
                            "He then pats you on the sholder, wishes you good luck, and walks down the path.");
                        Console.WriteLine("+5 bonus to Damage");
                        damage = damage += 5.0f;
                        Console.WriteLine("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (input == '2')
                    {
                        Console.WriteLine("\nYou ignore the old man and continue walking down the trail.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (input == '3')
                    {
                        if (role == "Wizard")
                        {
                            Console.WriteLine("\nYou go to cast a fireball at the old man but nothing happens.");
                            Console.WriteLine("The old man looks at you with faded eyes and smiles. " +
                                "He waves his hand and you feel a burning sensation from your staff.");
                            Console.WriteLine("Loose 20 Health");
                            health -= 20.0f;
                            Console.WriteLine("The old man vanishes in a piller of smoke.");
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Knight")
                        {
                            Console.WriteLine("\nYou charge at the old man with your sword when he vanishes in a piller of smoke.");
                            Console.WriteLine("Reappearing behind you; he looks at you with faded eyes, smiles, and waves his hand. " +
                                "You feel a burning sensation from your sword.");
                            Console.WriteLine("Loose 20 Health");
                            health -= 20.0f;
                            Console.WriteLine("The old man vanishes in a piller of smoke.");
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Rogue") 
                        {
                            Console.WriteLine("\nYou dash at the old man with daggers in each hand, but he vanishes in a piller of smoke.");
                            Console.WriteLine("Reappearing behind you; he looks at you with faded eyes, smiles, and waves his hand. " +
                                "You feel a burning sensation from your daggers.");
                            Console.WriteLine("Loose 20 Health");
                            health -= 20.0f;
                            Console.WriteLine("The old man vanishes in a piller of smoke.");
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid Input");
                    }
                }

                //i miss learning this
                //Always comment your code

            }
        }
    }
}
