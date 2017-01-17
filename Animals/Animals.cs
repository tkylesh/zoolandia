using System;

namespace Zoolandia.Animals
{
    public class Animal
    {
        public string name { get; set; }
        public int arms {get; set;}
        public int legs {get; set;}

        public bool fur {get; set;}


        public void sleep ()
        {
            Console.WriteLine("ZZzzzzzzz...");
        }
    }

}