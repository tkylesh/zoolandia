using System;

namespace Zoolandia.Animals
{
    public class Animal
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
     public class AilurusFulgens : Animal
    {
        // Define simple properties for a Red Panda
        public bool eatsBamboo {get; set;}
    }

     public class Bear: Animal
    {
        public string height {get; set;}
        public int weight {get; set;}

        public bool hasClaws {get; set;}
    }

    public class Dog: Animal
    {
        public bool hasTail {get; set;}

        public bool chasesSquirells {get; set;}

    }
}