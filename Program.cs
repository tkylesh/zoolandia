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
            redPanda = new AilurusFulgens(4);
            redPanda = new AilurusFulgens("Mrs. PANDA RED",4);
            redPanda.eatsBamboo = true;
            Console.WriteLine("Implementation of red panda");
            Console.WriteLine($"(true/false) Does a red panda eat bamboo? {redPanda.eatsBamboo}.");
            Console.WriteLine($"panda's name is  {redPanda.name}, she has {redPanda.legs} legs.");
            redPanda.sleep();
            Console.WriteLine("\n");

            //Instance of bear class
            Console.WriteLine("Implementation of bear");
            var bear = new Bear("yogi");
            bear = new Bear(4);
            bear = new Bear("YOGI",4);
            Console.WriteLine($"bear's name is {bear.name}, he has {bear.legs} legs.");
            bear.Roar();
            bear.sleep();
            bear.hasClaws = true;
            Console.WriteLine("\n");
            


            //Instance of dog class
            Console.WriteLine("Implementation of bear");
            var dog = new Dog("zero");
            dog = new Dog(4);
            dog = new Dog("ZERO",4);
            Console.WriteLine($"dog's name is {dog.name}, he has {dog.legs} legs.");
            dog.bark();
            dog.chasesSquirells = true;
            dog.sleep();
            Console.WriteLine("\n");
        }
    }
}
