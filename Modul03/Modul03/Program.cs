using System;

namespace Modul03
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");

			double a = 0, b = 0;

			Console.Write (" > a = ");  a = Convert.ToDouble (Console.ReadLine ());
			Console.Write (" > b = ");  b = Convert.ToDouble (Console.ReadLine ());

		//	Console.WriteLine ("\n\n> a/b : " + (a / b).ToString ("C2"));  // вариант с формат лева 2 знака 

		//	Console.WriteLine ("\n\n> a/b : " + (a / b).ToString ("P2"));  // формат процент  2 знака 

			string _format = "#0.00 м3";

			Console.WriteLine ("\n\n> a/b : " + (a / b).ToString (_format));  // ръчено добавен  формат 

		}
	}
}
