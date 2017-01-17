using System;

namespace Zoolandia.Animals
{
        public class Dog: Animal
    {

        public Dog(string name)
        {
            this.name = name;
        }

        public Dog(int legs)
        {
            this.legs = legs;
        }

        public Dog(string name, int legs)
        {
            this.name = name;
            this.legs = legs;
        }
        public bool hasTail {get; set;}

        public bool chasesSquirells {get; set;}

        public void bark()
        {
            Console.WriteLine("ardvark! ardvark!");
        }

        public override void sleep()
        {
            Console.WriteLine("barksnorreee!");
        }

    }

}