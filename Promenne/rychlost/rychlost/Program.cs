using System;

namespace rychlost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Převod rychlosti");
            Console.WriteLine("Zadejte rychlost v m/s");
            string rychlost = Console.ReadLine();
            float v = float.Parse(rychlost);
            double kilometryzahodinu;
            kilometryzahodinu=(3.6*v);
            Console.WriteLine("Rychlost v km/h je");
            Console.WriteLine(kilometryzahodinu);
            Console.ReadKey();
        }
    }
}
