using System;
using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
    public class WoodlandHabitat : Habitat, IWoodlandHabitat
    {
        public int acres {get; set;}
        public void grass()
        {
            Console.WriteLine("grass.");
        }

        public void trees()
        {
            Console.WriteLine("trees.");
        }

        public WoodlandHabitat (string name, int acres)
        {
            this.acres = acres;
            this.public_name = name;
        }
    }
}