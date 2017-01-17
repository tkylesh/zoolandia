using System;
using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
    public class WoodlandHabitat : Habitat, IWoodlandHabitat
    {
        public int acres
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void grass()
        {
            throw new NotImplementedException();
        }

        public void trees()
        {
            throw new NotImplementedException();
        }

        public WoodlandHabitat (string name, int acres)
        {
            this.acres = acres;
            this.public_name = name;
        }
    }
}