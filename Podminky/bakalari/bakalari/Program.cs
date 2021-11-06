using System;

namespace bakalari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bakaláři");
            Console.WriteLine("Zadejte známku");
            int znamka = int.Parse(Console.ReadLine());
            if (znamka >= 5 || znamka <= 1)
                Console.WriteLine("Tuto známku nelze zadat");
            Console.ReadKey();
            return;
            
        }
    }
}
