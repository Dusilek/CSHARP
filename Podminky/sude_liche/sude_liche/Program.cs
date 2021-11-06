using System;

namespace sude_liche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sudé nebo liché číslo");
            Console.WriteLine("Zadej celé číslo: ");
            int cislo = int.Parse(Console.ReadLine());
            if (cislo % 2 == 0)
                Console.WriteLine("Číslo je sudé\n");
            if (cislo % 2 != 0)
                Console.WriteLine("Číslo je liché\n");
            Console.WriteLine("Stiskněte cokoliv");
            Console.ReadKey();
                    }
    }
}
