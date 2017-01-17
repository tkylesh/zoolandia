using System;

namespace Zoolandia.Animals
{
    // Genus class, inherits from animal class
    public class Falco:Animal
    {
        //add properties and methods
    } 

    // Species class, inherits from the corresponding genus class
    public class Falconiforme:Crocodylus
    {
        string commonName = "Falcon";
        string scientificName = "Falconiforme";
        
    }
}