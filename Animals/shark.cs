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

        public CarcharodonCarcharias(string name)
        {
            this.name = name;
        }

        public CarcharodonCarcharias(int legs)
        {
            this.legs = legs;
        }

        public CarcharodonCarcharias(string name, int legs)
        {
            this.name = name;
            this.legs = legs;
        }

        public override void sleep()
        {
            Console.WriteLine("chompsnorreee!");
        }

    }

}