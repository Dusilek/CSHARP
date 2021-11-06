using System;

namespace kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jednoduchá kalkulačka");
            Console.WriteLine("Zadejte první číslo");
            string prvnicislo = Console.ReadLine();
            float cislo_1 = float.Parse(prvnicislo);
            Console.WriteLine("Zadejte druhé číslo");
            string druhecislo = Console.ReadLine();
            float cislo_2 = float.Parse(druhecislo);
            float soucet;
            float rozdil;
            float soucin;
            float podil;
            soucet = cislo_1 + cislo_2;
            rozdil = cislo_1 - cislo_2;
            soucin = cislo_1 * cislo_2;
            podil = cislo_1 / cislo_2;
            Console.WriteLine("Součet čísel je");
            Console.WriteLine(soucet);
            Console.WriteLine("Rozdíl čísel je");
            Console.WriteLine(rozdil);
            Console.WriteLine("Součin čísel je");
            Console.WriteLine(soucin);
            Console.WriteLine("Podíl čísel je");
            Console.WriteLine(podil);
            Console.ReadKey();
        }
    }
}
