using System;

namespace rychlost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Převod rychlosti");
            Console.WriteLine("Zadejte rychlost v km/h");
            string rychlost = Console.ReadLine();
            float v = float.Parse(rychlost);
            double metryzasekundu;
            metryzasekundu = (v/3.6);
            Console.WriteLine("Rychlost v m/s je");
            Console.WriteLine(metryzasekundu);
            Console.ReadKey();
        }
    }
}
