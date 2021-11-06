using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odmocnina z čísla");
            Console.WriteLine("Zadej nějaké číslo, ze kterého spočítám odmocninu:");
            int a = int.Parse(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("Zadal jsi číslo větší než 0, to znamená, že ho mohu odmocnit!");
                double o = Math.Sqrt(a);
                Console.WriteLine("Odmocnina z čísla " + a + " je " + o);
            }
            else
                Console.WriteLine("Zadal jsi záporné číslo a záporné číslo nemohu odmocnit!");
            Console.WriteLine("Stiskni cokoliv");
            Console.ReadKey();
        }
    }
}
