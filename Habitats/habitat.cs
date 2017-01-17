using System;
using System.Collections.Generic;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
  public class Habitat
  {
      // Instantiated a new list, which will contain animals.
      // You will add animals at run time (i.e. in `static void Main()
      // `)
      public List<Animal> inhabitants = new List<Animal>();
      public string public_name { get; set; }
  }

  public interface IAquaticHabitat
  {
    void empty();
    void fill();

    double volume { get; set; }
  }

  public class Aquarium : Habitat, IAquaticHabitat
  {
      private bool _saltwater = false;
      public double volume { get; set; }
      public void empty()
      {
        throw new System.NotImplementedException();
      }
      public void fill()
      {
        throw new System.NotImplementedException();
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