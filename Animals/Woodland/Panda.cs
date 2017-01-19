using System;

namespace Zoolandia.Animals
{

    // Genus class, inherits from animal class
    public class Ailuropoda: Animal
    {
        //add properties and methods
    }

    // Species class, inherits from the corresponding genus class
    // The species for a Giant Panda
     public class Ailuropodamelanoleuca: Ailuropoda
    {
        public string commonName = "Giant Panda";
        public string scientificName = "Ailuropodamelanoleuca";

        public string genus = "Ailuropoda";
        public Ailuropodamelanoleuca(string name)
        {
            this.name = name;
        }

        public Ailuropodamelanoleuca(int legs)
        {
            this.legs = legs;
        }

        public Ailuropodamelanoleuca(string name, int legs)
        {
            this.name = name;
            this.legs = legs;
        }
        
        // Define simple properties for a Red Panda
        public bool eatsBamboo {get; set;}


        //overloaded methods
        public void eat()
        {
            Console.WriteLine($"{this.name} needs to eat.");
        }
        public void eat(string food)
        {
            Console.WriteLine($"You gave {this.name} some {food} to eat.");
        }
        //public virtual method override
        public override void sleep()
        {
            Console.WriteLine("sleeping panda!");
        }
        public override void run()
        {
            Console.WriteLine("no need to run.");
        }
    }

}