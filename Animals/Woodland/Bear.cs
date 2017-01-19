using System;

namespace Zoolandia.Animals
{
    // Genus class, inherits from animal class
    public class Ursus:Animal
    {
        //add properties and methods
    }

    // Species class, inherits from the corresponding genus class
     public class UrsusArctosHorriblis: Ursus
    {
        public string commonName = "Grizzly Bear";
        public string scientificName = "Ursus Arctos Horriblis";

        public string genus = "Ursus";

        //overloaded methods
        public void eat()
        {
            Console.WriteLine($"{this.name} needs to eat.");
        }
        public void eat(string food)
        {
            Console.WriteLine($"You gave {this.name} some {food} to eat.");
        }
        public UrsusArctosHorriblis(string name)
        {
            this.name = name;
        }

        // public UrsusArctosHorriblis(int legs)
        // {
        //     this.legs = legs;
        // }

        // public UrsusArctosHorriblis(string name, int legs)
        // {
        //     this.name = name;
        //     this.legs = legs;
        // }
        public void Roar()
        {
            Console.WriteLine("RAAAWWR!");        
        }

        public bool hasClaws {get; set;}

        //public virtual method override
        public override void sleep()
        {
            Console.WriteLine("snorreee!");
        }

        public override void run()
        {
            Console.WriteLine("You can't outrun a bear, you gotta wrastle `em");
        }
    }
}
