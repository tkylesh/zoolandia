using System;

namespace Zoolandia.Animals
{
    // Genus class, inherits from animal class
    public class Panthera:Animal
    {
        //add properties and methods
    } 

    // Species class, inherits from the corresponding genus class
    public class PantheraTigris:Crocodylus
    {
        string commonName = "Tiger";
        string scientificName = "Panthera Tigris";
    }
}