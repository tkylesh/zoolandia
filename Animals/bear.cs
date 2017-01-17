using System;

namespace Zoolandia.Animals
{
     public class Bear: Animal
    {
        public Bear(string name)
        {
            this.name = name;
        }

        public Bear(int legs)
        {
            this.legs = legs;
        }

        public Bear(string name, int legs)
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
