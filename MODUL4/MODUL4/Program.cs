using System;

namespace MODUL4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[ , ] _table = {
				{ "Иван", "Георгиев", "19" },  
				{ "Георги ", "Георгиев", "25" },
				{ "Владимир", "Павлов", "32" },  
				{ "Теди", "Тодоров", "50" },			
				{ "Цецо", "Георгиев", "40" }, 
				{ "Лора", "Трифонова", "16" } 
			};

			// антетка 
			Console.WriteLine("Име".PadRight(12)+ "Фамилия".PadRight(12)+"Години".PadRight(12)) ;
			Console.WriteLine("==============================");

			//for (int i = 0; i < _table.Length /3 ; i++)    // за i = 0 и i /3 = БРОЯ НА РЕДОВЕТЕ които ще обходим
			//      {
		//		for (int j	= 0; j < 3; j++)    //  във 2-рия цикъл за всеки ред ще обходим броя на колоните 
		//		{
					//		тяло на таблицата
		//			Console.Write( _table[i,j].PadRight(12));	
		//		}

		//		Console.WriteLine ();
		
//			int i =0 ;
//			while (i < _table.Length /3) 
//			
//			{
//				Console.WriteLine (
//					
//					_table [i, 0].PadRight(12) +
//					_table [i, 1].PadRight(12) +
//					_table [i, 2].PadRight(12) 
//				);
//
//
//				i++;													
//			}	
   	
			// Примери с DO WHILE  

			int i = 0;
			//Kod

			do {

				Console.WriteLine (
					_table [i, 0].PadRight (12) +
					_table [i, 1].PadRight (12) +
					_table [i, 2].PadRight (12)
				);  
				i++;
			}
			while (i < _table.Length / 3) ;

		} 
	}
}




