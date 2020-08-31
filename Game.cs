using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

                //Adds typed out look to text
                //function that prints out message one leter at a time with a wait between each letter then goes to the next line
                //i did get this off the internet and for the most part i do understand what it's saying
                static void typewrite(string message)
                {
                    for (int i = 0; i < message.Length; i++)
                    {
                        Console.Write(message[i]);
                        System.Threading.Thread.Sleep(35);
                    }
                    Console.WriteLine();
                }

                //This variable is used to deciede health and death 
                float health = 100.0f;
                if (health <= 0.0f)
                {
                    gameOver = true;
                    typewrite("You Died");
                    typewrite("G A M E  O V E R");
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
                typewrite("Hello traveler! What is your name?");
                string name = Console.ReadLine();
                typewrite("Welcome " + name + "! " + "Please select a Role!");

                //shows list of roles for player to choose from and decides stats based on role
                List<string> roles = new List<string> { "Press 1 for Wizard", "Press 2 for Knight", "Press 3 for Rogue" };
                roles.ForEach(Console.Write );
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
                typewrite("Nice to meet you " + name + ". " + "The Mighty " + role + ".");
                typewrite("This is you...");
                charStats(name, role, level, health, damage);

                //Intro
                typewrite("You are a mighty adventurer in unknown lands where monsters, theives, and many other dangers live. " +
                    "But there is also untold treasure and glory hidden on the path ahead. Like many adventurers before you, you take on the deadly task of exploring " +
                    "these unknown lands. Good Luck!");

                //Continues Adventure
                //Console.WriteLine("You continue your adventure.");
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();

                //First Interaction
                typewrite("You begin your walk and run into a little girl in a little red hood. " +
                    "She looks up at you and smiles. Holding out her basket, she offers you an apple");
                Console.WriteLine("Press 1 to question her");
                Console.WriteLine("Press 2 to take an apple");
                Console.WriteLine("Press 3 to attack");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    typewrite("\nYou ask the little girl, why she is in these dangerous lands.");
                    typewrite("She doesn't say anything, but holds the basket up higher for you to take an apple.");
                    Console.WriteLine("Press 1 to take apple");
                    Console.WriteLine("Press 2 to walk away");
                    Console.WriteLine("Press 3 to attack");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        typewrite("\nYou take an apple from the little girl and eat it.");
                        typewrite("The little girl smiles with large fang like teeth. She pulls off the little red hood and turns into a large wolf!");
                        Console.WriteLine("Press 1 to run away");
                        Console.WriteLine("Press 2 to attack");
                        input = Console.ReadKey().KeyChar;
                        if (input == '1')
                        {
                            typewrite("\nYou manage to get away, but not before the wolf attacks you.");
                            typewrite("Loose 20 Health");
                            health -= 20;
                            typewrite("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (input == '2')
                        {
                            if (role == "Wizard")
                            {
                                typewrite("\nYou cast a fireball at the wolf, frightening the wolf and causing the wolf to run away.");
                                typewrite("You continue your adventure.");
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (role == "Knight")
                            {
                                typewrite("\nYou swipe skillfully with your sword at the wolf, fightening the wolf and causing the wolf to run away.");
                                typewrite("You continue your adventure.");
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (role == "Rogue")
                            {
                                typewrite("\nYou quickly stab at the wolf, frightening the wolf and causing the wolf to run away.");
                                typewrite("You continue your adventure.");
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
                        typewrite("\nYou walk away from the little girl.");
                        typewrite("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (input == '3')
                    {
                        if (role == "Wizard")
                        {
                            typewrite("\nYou cast a fireball at the wolf, frightening the wolf and causing the wolf to run away.");
                            typewrite("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Knight")
                        {
                            typewrite("\nYou swipe skillfully with your sword at the wolf, fightening the wolf and causing the wolf to run away.");
                            typewrite("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Rogue")
                        {
                            typewrite("\nYou quickly stab at the wolf, frightening the wolf and causing the wolf to run away.");
                            typewrite("You continue your adventure.");
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
                    typewrite("\nYou take an apple from the little girl and eat it.");
                    typewrite("The little girl smiles with large fang like teeth. She pulls off the little red hood and turns into a large wolf!");
                    Console.WriteLine("Press 1 to run away");
                    Console.WriteLine("Press 2 to attack");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        typewrite("\nYou manage to get away, but not before the wolf attacks you.");
                        typewrite("Loose 20 Health");
                        health -= 20.0f;
                        typewrite("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (input == '2')
                    {
                        if (role == "Wizard")
                        {
                            typewrite("\nYou cast a fireball at the wolf, frightening the wolf and causing the wolf to run away.");
                            typewrite("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Knight")
                        {
                            typewrite("\nYou swipe skillfully with your sword at the wolf, fightening the wolf and causing the wolf to run away.");
                            typewrite("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Rogue")
                        {
                            typewrite("\nYou quickly stab at the wolf, frightening the wolf and causing the wolf to run away.");
                            typewrite("You continue your adventure.");
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
                        typewrite("\nYou cast a fireball at the girl, she throws off the hood, turns into a wolf, and runs away.");
                        typewrite("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (role == "Knight")
                    {
                        typewrite("\nYou swipe skillfully with your sword at the girl, she throws off the hood, turns into a wolf, and runs away.");
                        typewrite("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (role == "Rogue")
                    {
                        typewrite("\nYou quickly stab at the girl, she throws off the hood, turns into a wolf, and runs away.");
                        typewrite("You continue your adventure.");
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
                typewrite("You continue walking down the path when you come to a fork in the road.");
                Console.WriteLine("Press 1 to go left towads a Tall Grassy Meadow.");
                Console.WriteLine("Press 2 to go right towards a Dark Woods.");
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    typewrite("\nYou decide to walk towards the Tall Grassy Meadow and continue your adventure.");
                    area = "Tall Grassy Meadow";
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == '2')
                {
                    typewrite("\nYou decide to walk towards the Dark Woods and continue your adventure");
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
                    typewrite("You walk along the dark covered path and see an old man sitting on a fallen tree off the side of the road.");
                    typewrite("He looks up at you and asks you to help him up.");
                    Console.WriteLine("Press 1 to help him up");
                    Console.WriteLine("Press 2 to ignore and walk away");
                    Console.WriteLine("Press 3 to attack");
                    input = Console.ReadKey().KeyChar;
                    if (input == '1')
                    {
                        typewrite("\nYou help up the old man and see his faded eyes realizing he is blind.");
                        typewrite("He thanks you for your help and waves his hand over your weapon. " +
                            "He then pats you on the sholder, wishes you good luck, and vanishes in a pillar of smoke.");
                        typewrite("+5 bonus to Damage");
                        damage = damage += 5.0f;
                        typewrite("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (input == '2')
                    {
                        typewrite("\nYou ignore the old man and continue walking down the trail.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else if (input == '3')
                    {
                        if (role == "Wizard")
                        {
                            typewrite("\nYou go to cast a fireball at the old man but nothing happens.");
                            typewrite("The old man looks at you with faded eyes and smiles. " +
                                "He waves his hand and you feel a burning sensation from your staff.");
                            typewrite("Loose 20 Health");
                            health -= 20.0f;
                            typewrite("The old man vanishes in a pillar of smoke.");
                            typewrite("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Knight")
                        {
                            typewrite("\nYou charge at the old man with your sword when he vanishes in a pillar of smoke.");
                            typewrite("Reappearing behind you; he looks at you with faded eyes, smiles, and waves his hand. " +
                                "You feel a burning sensation from your sword.");
                            typewrite("Loose 20 Health");
                            health -= 20.0f;
                            typewrite("The old man vanishes in a pillar of smoke.");
                            typewrite("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else if (role == "Rogue")
                        {
                            typewrite("\nYou dash at the old man with daggers in each hand, but he vanishes in a pillar of smoke.");
                            typewrite("Reappearing behind you; he looks at you with faded eyes, smiles, and waves his hand. " +
                                "You feel a burning sensation from your daggers.");
                            typewrite("Loose 20 Health");
                            health -= 20.0f;
                            typewrite("The old man vanishes in a pillar of smoke.");
                            typewrite("You continue your adventure.");
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
