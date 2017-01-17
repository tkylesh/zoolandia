using System;
using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
    public class BirdHabitat : Habitat, IBirdHabitat
    {
        public int sqft
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

        public void perch()
        {
            throw new NotImplementedException();
        }

        public void trees()
        {
            throw new NotImplementedException();
        }

        public BirdHabitat (string name, int sqfeet)
        {
            this.sqft = sqfeet;
            this.public_name = name;
        }
    }
}