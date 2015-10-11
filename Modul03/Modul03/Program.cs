using System;

namespace Modul03
{
	class MainClass
	{
		public static void Main (string[] args)
		{


			double a = 0, b = 0, c =0;

			Console.Write (" > a = ");  a = Convert.ToDouble (Console.ReadLine ());
			Console.Write (" > b = ");  b = Convert.ToDouble (Console.ReadLine ());

			 //Console.WriteLine ("\n\n> a/b : " + (a / b).ToString ("C2"));  // вариант с формат лева 2 знака 

		    // Console.WriteLine ("\n\n> a/b : " + (a / b).ToString ("P2"));  // формат процент  2 знака 
		
			// форматиране с дименсия
			string _format = "#0.00 м3";

			Console.WriteLine ("\n\n> a/b : " + (a / b).ToString (_format));  // ръчено добавен  формат 
		

			// Степенуване 
			c = Math.Pow (a, b);
			Console.WriteLine ("\n\n> a ^ b : " + c.ToString (_format)); 

			// коренуване 
			c = Math.Sqrt (b);
			Console.WriteLine ("\n\n> b ^1/2 : " + c.ToString (_format)); 
		
			// Закръгляне 
			c = Math.Round(a / b);
			Console.WriteLine ("\n\n>( a / b ) : " + c.ToString (_format)); 
		}
	}
}
