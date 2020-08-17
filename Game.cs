using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        public void Run()
        {
            float health = 100.0f;
            float healthRegen = 20;
            string name = Console.ReadLine();
            int Maxlevel = 100;
            int level = Maxlevel;
            bool ready = false;
            Console.WriteLine(health);
            health = health + healthRegen;
            Console.WriteLine("You just healed!! " + healthRegen);
            Console.WriteLine(name + " just healed " + healthRegen);

            //i miss learning this

        }
    }
}
