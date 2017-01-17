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

  public interface IWoodlandHabitat
  {
    void trees();
    void grass();

    int acres {get; set;}
  }

  public interface IBirdHabitat
  {
    void perch();

    void trees();
    int sqft {get; set;}
  }
}