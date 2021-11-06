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
				Console.WriteLine("Správně, předtím jsi měl {0} bodů a teď máš o 1 víc!", bodu++);
		}
	}
}