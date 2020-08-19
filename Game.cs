using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
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
            if (input == '1')
            {
                role = "Wizard";
                health = 60.0f;
                damage = 20.0f;
            }
            else if (input == '2')
            {
                role = "Knight";
                health = 100.0f;
                damage = 10.0f;
            }
            else if (input == '3')
            {
                role = "Rogue";
                health = 80.0f;
                damage = 15.0f;
            }
            else
            {
                Console.WriteLine("Invalid input. Default Settings used.");
                role = "Adventurer";
                health = 90.0f;
                damage = 12.0f;
            }

            //Confirms character info
            Console.WriteLine("\nNice to meet you " + name + ". " + "The Mighty " + role + ". " + "You shall start with " + health + " health at level " + level + "." );

            //Intro
            Console.WriteLine("You are a mighty adventurer in unknown lands where monsters, theives, and many other dangers live. " +
                "But there is also untold treasure and glory hidden on the path ahead. Like many adventurers before you, you take on the deadly task of exploring " +
                "these unknown lands. Good Luck!");

            //Continues Adventure 
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();

            //First Interaction
            Console.WriteLine("You begain your walk and not long later run into a little girl in a little red hood. " +
                "She looks up at you and smiles. Holding out her basket, she offers you an apple");
            Console.WriteLine("Press 1 to question her");
            Console.WriteLine("Press 2 to take an apple");
            Console.WriteLine("Press 3 to attack");
            char input = Console.ReadKey().KeyChar;
            if (input == '1')
            {
                Console.WriteLine("You ask the little girl ");
            }

            //i miss learning this
            //Always comment your code

        }
    }
}
