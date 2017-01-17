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
        string commonName = "Grizzly Bear";
        string scientificName = "Ursus Arctos Horriblis";
        public UrsusArctosHorriblis(string name)
        {
            this.name = name;
        }

        public UrsusArctosHorriblis(int legs)
        {
            this.legs = legs;
        }

        public UrsusArctosHorriblis(string name, int legs)
        {
            this.name = name;
            this.legs = legs;
        }
        public void Roar()
        {
            Console.WriteLine("RAAAWWR!");        
        }

        public bool hasClaws {get; set;}

        public override void sleep()
        {
            Console.WriteLine("snorreee!");
        }
    }
}
