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

        public override void sleep()
        {
            Console.WriteLine("sleeping panda!");
        }
    }

}