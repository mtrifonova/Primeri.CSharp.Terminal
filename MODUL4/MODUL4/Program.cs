using System;

namespace MODUL4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string [] _table = { "Иван", "Гошо", "Гергана" };  // масив от тип стринг от тип с име table 

			for (int i = 0; i < _table.Length;i++)    // за i = 0 и i <дължината на таблицата 3;i++ - нараства с 1
			{
         // антетка 
				Console.WriteLine("Име");
				Console.WriteLine("===========");
		//		тяло на таблицата
				Console.WriteLine( _table[i]);
			}
		}
	}
}
