using System;

namespace TableProject
{
	class MainClass

	{

		enum ti  { ime=0, familia, godini };
		// при колони се използва при редове не ...Когато ми трябва фамилия не трябва да помня че е 2 колона пиша ti.familia

		public static void Main (string[] args)
		{

		//Дефиниране на таблица

		string[,] table = new string[2, 3];

		//Въвеждане на първи ред
		
			table [0, (int) ti.ime] = "Лора"; table [0,(int) ti.familia] = "Бойкова";  table [0, (int) ti.godini] = "16";
		
			//Въвеждане на втори ред

			table [0, (int) ti.ime] = "Бойко "; table [0,(int) ti.familia] = "Трифонов";  table [0, (int) ti.godini] = "45";

		 Console.WriteLine(" Кой ред искате да видите : " );

			int _index = Convert.ToInt32(Console.ReadLine()) -1 ;  // индекса е цял тип.Понеже в броенето 0 е първи ред пишим -1 

		Console.WriteLine((table[_index, (int)  ti.ime])[0] + "." + table[ _index, (int) ti.familia] + " , " +  table[ _index,(int)  ti.godini] + " г.");
			 
		}
	}
}



//			string[] row = new string[3];
//		
//			row[0] = "Ред 1";
//			row[1] = "Ред 2";
//		    row[2] = "Ред 3";
//
//			Console.WriteLine (" Масив row: " + row [0] + ", " + row [1] + ", " + row [2] + "\n");
//
//			string[] parse = "1,2,3,4,5,6,7,8,9".Split (','); // Split(,) разделя с , превръща този стринг в масив
//
//
//			Console.WriteLine (" Броят на елементите в масива  : " + "1,2,3,4,5,6,7,8,9\n е:  " + parse.Length);
//
//			string list1 = string.Join(";", parse);
//
//			Console.WriteLine(" Новият стринг е:\n " + list1 + "\n");