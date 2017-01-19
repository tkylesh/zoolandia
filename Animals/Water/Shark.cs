using System;

namespace Zoolandia.Animals
{
    // Genus class, inherits from animal class
    public class Carcharodon:Animal
    {
        //add properties and methods
    }

    // Species class, inherits from the corresponding genus class
    public class CarcharodonCarcharias: Carcharodon
    {
        public string commonName = "Great White Shark";
        public string scientificName = "Carcharodon Carcharias";

        public string genus = "Carcharodon";


        //overloaded methods
        public void eat()
        {
            Console.WriteLine($"{this.name} needs to eat.");
        }
        public void eat(string food)
        {
            Console.WriteLine($"You gave {this.name} some {food} to eat.");
        }
        public CarcharodonCarcharias(string name)
        {
            this.name = name;
        }

        // public CarcharodonCarcharias(int legs)
        // {
        //     this.legs = legs;
        // }

        // public CarcharodonCarcharias(string name, int legs)
        // {
        //     this.name = name;
        //     this.legs = legs;
        // }

        //public virtual method override
        public override void sleep()
        {
            Console.WriteLine("chompsnorreee!");
        }

        public override void run()
        {
            Console.WriteLine("dundun...dundun...dundun.dundun.dundun.");
        }

    }

}