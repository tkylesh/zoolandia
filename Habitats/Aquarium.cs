using System;
using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
    public class Aquarium : Habitat, IAquaticHabitat
    {
        private bool _saltwater = false;
        public double volume { get; set; }
        public void empty()
        {
            Console.WriteLine("Aquatic tank empty!");
        }
        public void fill()
        {
            Console.WriteLine("Aquatic tank fill!");
        }
        //   private List<Employee> scubaCrew = new List<Employee>();

        // `public_name`, and `saltwater` properties can only be set when habitat is created
        public Aquarium (string name, bool isSaltwater)
        {
            _saltwater = isSaltwater;
            this.public_name = name;
        }
    }
}