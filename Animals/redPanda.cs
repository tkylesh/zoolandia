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
        
        // Define simple properties for a Red Panda
        public bool eatsBamboo {get; set;}

        public override void sleep()
        {
            Console.WriteLine("sleeping panda!");
        }
    }

}