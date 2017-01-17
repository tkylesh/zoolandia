using System;
using Zoolandia.Animals;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Instance of red panda class
            var redPanda = new AilurusFulgens("Mr. panda red");
            redPanda.eatsBamboo = true;
            Console.WriteLine("Implementation of red panda");
            Console.WriteLine($"(true/false) Does a red panda eat bamboo? {redPanda.eatsBamboo}.");
            Console.WriteLine($"panda's name is  {redPanda.name}.");
            redPanda.sleep();
            Console.WriteLine("\n");

            //Instance of bear class
            Console.WriteLine("Implementation of bear");
            var bear = new Bear("yogi");
            Console.WriteLine($"bear's name is {bear.name}.");
            bear.Roar();
            bear.sleep();
            bear.hasClaws = true;
            Console.WriteLine("\n");
            


            //Instance of dog class
            Console.WriteLine("Implementation of bear");
            var dog = new Dog("zero");
            Console.WriteLine($"dog's name is {dog.name}.");
            dog.bark();
            dog.chasesSquirells = true;
            dog.sleep();
            Console.WriteLine("\n");
        }
    }
}
