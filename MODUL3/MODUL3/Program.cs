using System;

namespace MODUL3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Променливи от тип Double (дробни числа) 
			double a = 0, b = 0, c = 0;

			Console.Write (" > a = ");     a = Convert.ToDouble (Console.ReadLine ());

			Console.Write (" > b = ");   b = Convert.ToDouble (Console.ReadLine ());

		   //	Форматеране с дименсия 
			  string _format = "#0.00 m3";   // хубаво е предварително да се напише типа на формата

			//	Степенуване
			c = Math.Pow( a,b );
			Console.WriteLine ("\n\n a ^ b  = " + c.ToString (_format));
			//	Коренуване
			c = Math.Sqrt( b );
			Console.WriteLine ("\n\n b ^ 1/2  = " + c.ToString (_format));
			//	Степенуване
			c = Math.Round( a / b );
			Console.WriteLine ("\n\n (a / b )  = " + c.ToString (_format));
		}
	}
}