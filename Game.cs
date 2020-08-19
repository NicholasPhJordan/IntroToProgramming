using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
                //Introduction -- Player chooses name and role
            Console.WriteLine("Hello traveler! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "! " + "Please input a Role!");
                //shows list of roles for player to choose from
            List<string> roles = new List<string> { "Wizard", "Fighter", "Rogue" };
            roles.ForEach(Console.WriteLine);  
            string role = Console.ReadLine();
            //This variable is used to deciede health
            float health = 100.0f;
            if (role == "Wizard")
            {
                health = 60.0f;
            }
            else if (role == "Fighter")
            {
                health = 100.0f;
            } 
            else if (role == "rogue")
            {
                health = 80.0f;
            }
                //This value is used to heal the player
            float healthRegen = 20.0f;
                //Character level Info
            bool MaxlevelReached = false;
            int Maxlevel = 100;
            int level = 1;
            bool ready = true;
                //Confirms character info
            Console.WriteLine("Nice to meet you " + name + ". " + "The Mighty " + role + ". " + "You shall start with " + health + " health at level " + level + ". Good Luck!");

            //i miss learning this
            //Always comment your code

        }
    }
}
