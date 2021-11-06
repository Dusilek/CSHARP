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

			int bodu = 0;
			Console.WriteLine("Je Slunce koule žhavých plynů?");
			string spravnaOdpoved = "ano";
			string odpoved = Console.ReadLine();
			if (odpoved.ToLower() == spravnaOdpoved.ToLower())
			{
				bodu++;
				Console.WriteLine("Správně, máš celkem {0} bodů", bodu);
			}
		}
	}
}