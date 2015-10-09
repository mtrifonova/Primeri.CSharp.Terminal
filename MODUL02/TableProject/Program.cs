using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string[] row = new string[3];
		
			row[0] = "Ред 1";
			row[1] = "Ред 2";
		    row[2] = "Ред 3";

			Console.WriteLine (" Масив row: " + row [0] + ", " + row [1] + ", " + row [2] + "\n");

			string[] parse = "1,2,3,4,5,6,7,8,9".Split (','); // Split(,) разделя с , превръща този стринг в масив


			Console.WriteLine (" Броят на елементите в масива  : " + "1,2,3,4,5,6,7,8,9\n е:  " + parse.Length);

			string list1 = string.Join(";", parse);

			Console.WriteLine(" Новият стринг е:\n " + list1 + "\n");
		}
	}
}
