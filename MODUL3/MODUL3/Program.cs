using System;

namespace MODUL3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Променливи от тип Double (дробни числа) 
			double a = 0, b = 0;

			Console.Write
			(" > a = ");     a = Convert.ToDouble (Console.ReadLine ());

			Console.Write (" > b = ");   b = Convert.ToDouble (Console.ReadLine ());


		//	Console.WriteLine ("\n\n a / b  = " + (a / b).ToString ("C2")); CURRENCY цифрата 2 след С =2 знака след запетаята
		//	Console.WriteLine ("\n\n a / b  = " + (a / b).ToString ("P2")); процент цифрата 2 след Р знака след запетаята
			string _format = "#0.00 m3";   // хубаво е предварително да се напише типа на формата
			Console.WriteLine ("\n\n a / b  = " + (a / b).ToString (_format));
		}
	}
}