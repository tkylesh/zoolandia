using System;
using Zoolandia.Animals;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Instance of giant panda class
            var panda = new Ailuropodamelanoleuca("Mr. panda giant");
            panda = new Ailuropodamelanoleuca(4);
            panda = new Ailuropodamelanoleuca("Mrs. PANDA giant",4);
            panda.eatsBamboo = true;
            Console.WriteLine("Implementation of giant panda");
            Console.WriteLine($"(true/false) Does a giant panda eat bamboo? {panda.eatsBamboo}.");
            Console.WriteLine($"panda's name is  {panda.name}, she has {panda.legs} legs.");
            panda.sleep();
            Console.WriteLine("\n");

            //Instance of grizzly bear class
            Console.WriteLine("Implementation of bear");
            var bear = new UrsusArctosHorriblis("yogi");
            bear = new UrsusArctosHorriblis(4);
            bear = new UrsusArctosHorriblis("YOGI",4);
            Console.WriteLine($"bear's name is {bear.name}, he has {bear.legs} legs.");
            bear.Roar();
            bear.sleep();
            bear.hasClaws = true;
            Console.WriteLine("\n");
            


            //Instance of great white shark class
            Console.WriteLine("Implementation of shark");
            var shark = new CarcharodonCarcharias("zero");
            shark = new CarcharodonCarcharias(4);
            shark = new CarcharodonCarcharias("ZERO",4);
            Console.WriteLine($"shark's name is {shark.name}.");
            shark.sleep();
            Console.WriteLine("\n");
        }
    }
}
