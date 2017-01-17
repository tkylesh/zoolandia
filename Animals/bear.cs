using System;

namespace Zoolandia.Animals
{
     public class Bear: Animal
    {
        public Bear(string name)
        {
            this.name = name;
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
