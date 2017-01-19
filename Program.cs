using System;
using Zoolandia.Animals;
using Zoolandia.Habitats;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //Create new aquarium habitat
            Aquarium fishTank = new Aquarium("Aquarium", true);

            //Create new Animals
            CarcharodonCarcharias shark = new CarcharodonCarcharias("Great White Shark");
            Crocodile croc = new Crocodile("Nile Crocodile");

            //add animal to a list of Animals
            List<Animal> waterDwellers = new List<Animal>();
            waterDwellers.Add(shark);
            waterDwellers.Add(croc);

            //add to habitat inhabitants list
            fishTank.inhabitants = waterDwellers;

            //iterate over list
            Console.WriteLine("Habitat: Aquarium");
            foreach(Animal inhabitant in waterDwellers)
            {
                Console.WriteLine(inhabitant.name);
            }

            //create new woodland habitat
            WoodlandHabitat woods = new WoodlandHabitat("Woods", 2000);

            //Create new Animals
            UrsusArctosHorriblis bear = new UrsusArctosHorriblis("Grizzly Bear");
            Ailuropodamelanoleuca panda = new Ailuropodamelanoleuca("Giant Panda");
            PantheraTigris tiger = new PantheraTigris("Tiger");

            //add animal to a list of Animals
            List<Animal> landDwellers = new List<Animal>();
            landDwellers.Add(bear);
            landDwellers.Add(panda);
            landDwellers.Add(tiger);

            //add to habitat inhabitants list
            woods.inhabitants = landDwellers;
            //iterate over list
            Console.WriteLine("\n\n");
            Console.WriteLine("Habitat: Woodlands");
            foreach(Animal inhabitant in landDwellers)
            {
                Console.WriteLine(inhabitant.name);
            }


            //Create new bird habitat
            BirdHabitat birdHabitat = new BirdHabitat("Bird Habitat", 4000);

            //Create new Animals
            Falconiforme falcon = new Falconiforme("Falcon");

            //add animal to a list of Animals
            List<Animal> birds = new List<Animal>();
            birds.Add(falcon);

            //add to habitat inhabitants list
            birdHabitat.inhabitants = birds;

            //iterate over list
            Console.WriteLine("\n\n");
            Console.WriteLine("Habitat: Bird Habitat");
            foreach(Animal inhabitant in birds)
            {
                Console.WriteLine(inhabitant.name);
            }
            
                        



            //Instance of giant panda class
            // var panda = new Ailuropodamelanoleuca("Mr. panda giant");
            // panda = new Ailuropodamelanoleuca(4);
            // panda = new Ailuropodamelanoleuca("Mrs. PANDA giant",4);
            // panda.eatsBamboo = true;
            // Console.WriteLine("Implementation of giant panda");
            // Console.WriteLine($"(true/false) Does a giant panda eat bamboo? {panda.eatsBamboo}.");
            // Console.WriteLine($"panda's name is  {panda.name}, she has {panda.legs} legs.");
            // panda.sleep();
            // Console.WriteLine("\n");

            //Instance of grizzly bear class
            // Console.WriteLine("Implementation of bear");
            // var bear = new UrsusArctosHorriblis("yogi");
            // bear = new UrsusArctosHorriblis(4);
            // bear = new UrsusArctosHorriblis("YOGI",4);
            // Console.WriteLine($"bear's name is {bear.name}, he has {bear.legs} legs.");
            // bear.Roar();
            // bear.sleep();
            // bear.hasClaws = true;
            // Console.WriteLine("\n");
            
            //Instance of great white shark class
            // Console.WriteLine("Implementation of shark");
            // var shark = new CarcharodonCarcharias("zero");
            // shark = new CarcharodonCarcharias(4);
            // shark = new CarcharodonCarcharias("ZERO",4);
            // Console.WriteLine($"shark's name is {shark.name}.");
            // shark.sleep();
            // Console.WriteLine("\n");
        }
    }
}
