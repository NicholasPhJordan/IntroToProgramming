using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            //Introduction -- Player cooses name and role
            Console.WriteLine("Hello traveler! What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + "! " + "Please input a Role!");
            string role = Console.ReadLine();
            //This variable is used to store health
            float health = 100.0f;
            //This value is used to heal the player
            float healthRegen = 20.0f;
            //Character level Info
            bool MaxlevelReached = false;
            int Maxlevel = 100;
            int level = 1;
            bool ready = true;
            //Confirms character info
            Console.WriteLine("Nice to meet you " + name + ". " + " The Mighty " + role + ". " + "You have " + health + " health and shall start at level " + level + ". Good Luck!");

            //i miss learning this
            //Always comment your code

        }
    }
}
