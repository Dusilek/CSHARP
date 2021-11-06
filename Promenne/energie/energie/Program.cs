using System;

namespace energie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte hmotnost tělesa");
            string hmotnost=Console.ReadLine();
            float m = float.Parse(hmotnost);
            int gravitace = 10;
            Console.WriteLine("Zadejte výšku tělesa nad zemí");
            string vyska = Console.ReadLine();
            float v = float.Parse(vyska);
            float penergie;
            penergie = (m * gravitace * v);
            Console.WriteLine("Potencionální energie tělesa je");
            Console.WriteLine(penergie);
            Console.ReadKey();
        }
    }
}
