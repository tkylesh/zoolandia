using System;

namespace Zoolandia.Animals
{
        public class Dog: Animal
    {
        public bool hasTail {get; set;}

        public bool chasesSquirells {get; set;}

        public void bark()
        {
            Console.WriteLine("ardvark! ardvark!");
        }

    }

}