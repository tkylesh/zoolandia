using System;

namespace Zoolandia.Animals
{
    class Animal
    {
        public string name { get; set; }
        public int arms {get; set;}
        public int legs {get; set;}

        public bool fur {get; set;}


        public void sleep ()
        {
            Console.WriteLine("ZZzzzzzzz...");
        }
    }

    // The species for a Red Panda
    class AilurusFulgens : Animal
    {
        // Define simple properties for a Red Panda
        public string eats {get; set;}
    }
}