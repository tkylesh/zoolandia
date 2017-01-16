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
            var redPanda = new AilurusFulgens();
            redPanda.eatsBamboo = true;
            Console.WriteLine("(true/false) Does a red panda eat bamboo? "+ redPanda.eatsBamboo + "\n");
            redPanda.name = "Mr. panda red";
            Console.WriteLine("panda's name is "+ redPanda.name + "\n");
        }
    }
}
