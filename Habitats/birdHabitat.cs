using System;
using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
    public class BirdHabitat : Habitat, IBirdHabitat
    {
        public int sqft {get; set;}

        public void perch()
        {
            Console.WriteLine("perch.");
        }

        public void trees()
        {
            Console.WriteLine("trees.");
        }

        public BirdHabitat (string name, int sqfeet)
        {
            this.sqft = sqfeet;
            this.public_name = name;
        }
    }
}