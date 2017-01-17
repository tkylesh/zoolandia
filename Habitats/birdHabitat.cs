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
    }
}