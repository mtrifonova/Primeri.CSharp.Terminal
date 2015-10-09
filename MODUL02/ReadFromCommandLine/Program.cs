using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//  Дефиниране на променливи

			int a = 5 , b = 0;

			// Въвеждане на входни параметри

			Console.Write(" Моля  въведете a:");
			b = Convert.ToInt32( Console.ReadLine() );

			// Печат на резултат

			Console.WriteLine("Резултатът от сбора на a + b е: " + (a + b).ToString() + "\n" );

			string test = "1";
			test += " , 2";
			test += " , 100";
			test += " , 4";
			test += " , 5";
			Console.WriteLine ("Събиране +=  : " + test + "\n" );

			test = test.Replace (" ,", ";");
			Console.WriteLine ("Работa с Replace : " + test + "\n" );

			Console.WriteLine ("3-ти знак : " + test.Split(';')[2] + "\n" );









		}

	}
}
				