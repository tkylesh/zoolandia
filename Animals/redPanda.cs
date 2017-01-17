using System;

namespace Zoolandia.Animals
{

 // The species for a Red Panda
     public class AilurusFulgens : Animal
    {
        public AilurusFulgens(string name)
        {
            this.name = name;
        }

        public AilurusFulgens(int legs)
        {
            this.legs = legs;
        }

        public AilurusFulgens(string name, int legs)
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