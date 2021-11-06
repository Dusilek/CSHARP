using System;

namespace vetsi_mensi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Je číslo menší nebo větší");
            Console.WriteLine("Zadejte první číslo");
            float prvnicislo = float.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte druhé číslo");
            float druhecislo = float.Parse(Console.ReadLine());
            if (prvnicislo > druhecislo)
                Console.WriteLine("První číslo je větší");
            if (druhecislo>prvnicislo)
            Console.WriteLine("Druhé číslo je větší");
            Console.ReadKey();
        }
    }
}
