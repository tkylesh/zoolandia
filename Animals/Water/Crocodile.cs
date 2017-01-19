using System;

namespace Zoolandia.Animals
{
    // Genus class, inherits from animal class
    public class Crocodylus:Animal
    {
        //add properties and methods
    } 

    // Species class, inherits from the corresponding genus class
    public class Crocodile:Crocodylus
    {

        public string commonName = "Crocodile";
        public string scientificName = "Crocodylus";

        public string genus = "Crocodylus";

        //constructor method
        public Crocodile(string name)
        {
            this.name = name;
        }

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
            Console.WriteLine("get out of the water!");
        }
    }

}