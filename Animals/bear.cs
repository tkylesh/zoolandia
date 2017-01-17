using System;

namespace Zoolandia.Animals
{
     public class Bear: Animal
    {
        public void Roar()
        {
            Console.WriteLine("RAAAWWR!");        
        }

        public bool hasClaws {get; set;}
    }
}
