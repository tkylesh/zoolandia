using System;

namespace Zoolandia.Animals
{
    //interfaces
    interface LandDweller
    {
        void run();
        void walk();
    }

    interface WaterDweller
    {
        void swim();
    }

    interface Flying
    {
        void fly();
        void land();
    }

    // Base animal class
    public class Animal
    {
        public string name { get; set; }
        public int arms {get; set;}
        public int legs {get; set;}

        public bool fur {get; set;}

        public string species {get; set;}


        public virtual void sleep ()
        {
            Console.WriteLine("ZZzzzzzzz...");
        }

        public virtual void run()
        {
            Console.WriteLine("runnnnnn!!!!!!!");
        }
    }

}