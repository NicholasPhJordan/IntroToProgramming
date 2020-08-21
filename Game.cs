using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //Decides the color of the text
            Console.ForegroundColor = ConsoleColor.Green;
            
            //This variable is used to deciede health
            float health = 100.0f;

            //This value is used to heal the player
            float healthRegen = 20.0f;

            //Decides damage
            float damage = 20.0f;

            //Character level Info
            bool MaxlevelReached = false;
            int Maxlevel = 100;
            int level = 1;

            //stores players role
            string role = "none";
            bool ready = true;

            //Introduction -- Player chooses name and role
            Console.WriteLine("Hello traveler! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "! " + "Please select a Role!");

            //shows list of roles for player to choose from and decides stats based on role
            List<string> roles = new List<string> { "Press 1 for Wizard", "Press 2 for Knight", "Press 3 for Rogue" };
            roles.ForEach(Console.WriteLine);
            char input = Console.ReadKey().KeyChar;
            while (input != '1' || input != '2' || input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    role = "Wizard";
                    health = 60.0f;
                    damage = 20.0f;
                    break;
                }
                else if (input == '2')
                {
                    role = "Knight";
                    health = 100.0f;
                    damage = 10.0f;
                    break;
                }
                else if (input == '3')
                {
                    role = "Rogue";
                    health = 80.0f;
                    damage = 15.0f;
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input.");
                    continue;
                }
            }
            

            //Confirms character info
            Console.WriteLine("\nNice to meet you " + name + ". " + "The Mighty " + role + ".");
            Console.WriteLine("This is you...");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Role: " + role);
            Console.WriteLine("Level: " + level);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

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
            Console.WriteLine("You begin your walk and not long later run into a little girl in a little red hood. " +
                "She looks up at you and smiles. Holding out her basket, she offers you an apple");
            Console.WriteLine("Press 1 to question her");
            Console.WriteLine("Press 2 to take an apple");
            Console.WriteLine("Press 3 to attack");
            while (input != '1' || input != '2' || input != '3')
            {
                input = Console.ReadKey().KeyChar;
                if (input == '1')
                {
                    Console.WriteLine("\nYou ask the little girl, why she is in these dangerous lands.");
                    Console.WriteLine("She doesn't say anything, but holds the basket up higher for you to take an apple.");
                    Console.WriteLine("Press 1 to take apple");
                    Console.WriteLine("Press 2 to walk away");
                    Console.WriteLine("Press 3 to attack");
                    while (input != '1' || input != '2' || input != '3')
                    {
                        input = Console.ReadKey().KeyChar;
                        if (input == '1')
                        {
                            Console.WriteLine("\nYou take an apple from the little girl and eat it.");
                            Console.WriteLine("The little girl smiles with large fang like teeth. She pulls off the little red hood and turns into a large wolf!");
                            Console.WriteLine("Press 1 to run away");
                            Console.WriteLine("Press 2 to attack");
                            while (input != '1' || input != '2')
                            {
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
                                    break;
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
                                        break;
                                    }
                                    else if (role == "Knight")
                                    {
                                        Console.WriteLine("\nYou swipe skillfully with your sword at the wolf, fightening the wolf and causing the wolf to run away.");
                                        Console.WriteLine("You continue your adventure.");
                                        Console.WriteLine("Press any key to continue.");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    else if (role == "Rogue")
                                    {
                                        Console.WriteLine("\nYou quickly stab at the wolf, frightening the wolf and causing the wolf to run away.");
                                        Console.WriteLine("You continue your adventure.");
                                        Console.WriteLine("Press any key to continue.");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nInvalid Input");
                                    continue;
                                }
                            }
                        }
                        else if (input == '2')
                        {
                            Console.WriteLine("\nYou walk away from the little girl and continue your adventure");
                            Console.WriteLine("You continue your adventure.");
                            Console.WriteLine("Press any key to continue.");
                            Console.ReadKey();
                            Console.Clear();
                            break;
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
                                break;
                            }
                            else if (role == "Knight")
                            {
                                Console.WriteLine("\nYou swipe skillfully with your sword at the wolf, fightening the wolf and causing the wolf to run away.");
                                Console.WriteLine("You continue your adventure.");
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            else if (role == "Rogue")
                            {
                                Console.WriteLine("\nYou quickly stab at the wolf, frightening the wolf and causing the wolf to run away.");
                                Console.WriteLine("You continue your adventure.");
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Input");
                            continue;
                        }
                    } 
                }
                else if (input == '2')
                {
                    Console.WriteLine("\nYou take an apple from the little girl and eat it.");
                    Console.WriteLine("The little girl smiles with large fang like teeth. She pulls off the little red hood and turns into a large wolf!");
                    Console.WriteLine("Press 1 to run away");
                    Console.WriteLine("Press 2 to attack");
                    while (input != '1' || input != '2')
                    {
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
                            break;
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
                                break;
                            }
                            else if (role == "Knight")
                            {
                                Console.WriteLine("\nYou swipe skillfully with your sword at the wolf, fightening the wolf and causing the wolf to run away.");
                                Console.WriteLine("You continue your adventure.");
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                            else if (role == "Rogue")
                            {
                                Console.WriteLine("\nYou quickly stab at the wolf, frightening the wolf and causing the wolf to run away.");
                                Console.WriteLine("You continue your adventure.");
                                Console.WriteLine("Press any key to continue.");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid Input");
                            continue;
                        }
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
                        break;
                    }
                    else if (role == "Knight")
                    {
                        Console.WriteLine("\nYou swipe skillfully with your sword at the girl, she throws off the hood, turns into a wolf, and runs away.");
                        Console.WriteLine("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                    else if (role == "Rogue")
                    {
                        Console.WriteLine("\nYou quickly stab at the girl, she throws off the hood, turns into a wolf, and runs away.");
                        Console.WriteLine("You continue your adventure.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Input");
                    continue;
                }
            }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            //Path Diverges
            Console.WriteLine("You continue walking down the path when you come to a fork in the road.");
            Console.WriteLine("Press 1 to go left towads a tall grassy meadow.");
            Console.WriteLine("Press 2 to go right towards a dark woods.");
            while (input != '1' || input != '2')
            {
                if (input == '1')
                {
                    Console.WriteLine("\nYou decide to walk towards the Tall Grassy Meadow and continue your adventure.");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (input == '2')
                {
                    Console.WriteLine("\nYou decide to walk towards the Dark Woods and continue your adventure");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }

            //i miss learning this
            //Always comment your code

        }
    }
}
