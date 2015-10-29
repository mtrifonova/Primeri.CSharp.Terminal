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


			Console.WriteLine ("\n\n a / b  = " + (a / b).ToString ());
		}
	}
}