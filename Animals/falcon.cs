using System;

namespace Zoolandia.Animals
{
    // Genus class, inherits from animal class
    public class Falco:Animal
    {
        //add properties and methods
    } 

    // Species class, inherits from the corresponding genus class
    public class Falconiforme:Crocodylus
    {
        string commonName = "Falcon";
        string scientificName = "Falconiforme";

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
        public override void run()
        {
            Console.WriteLine("ehh, probably don't need to run.");
        }
        
    }
}