using System;

namespace MODUL02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на променливи
			int a = 0, b = 0;
			int sum = 0;
			string program_name = " Модул02 - Примери";
			string program_version = " 1.0";
			//Събиране на числа
			a = 10;
			b = 5;
			sum = a + b;
			// Данни за програмата
			Console.WriteLine (program_name);
			Console.WriteLine ( " Версия: " + program_version + " \n\n ");

			// Писане в  конзола
			Console.Write (a);
			Console.Write (" + ");
			Console.Write (b);
			Console.Write (" = ");
			Console.WriteLine (sum);

			//Доплнитилни оператори
			Console.WriteLine ("\nИзползване на += ");
			a += b; // a= 10 + 5 = 15. a = a+ b; старата стойност на а + в
			Console.WriteLine (a);
			Console.WriteLine ("\nИзползване на -= ");
			a -= b; // a= 15 - 5 = 10. a = a- b;старата стойност на а - в
			Console.WriteLine (a);
			Console.WriteLine ("\nИзползване на *= ");
			a *= b; // a= 10 * 5 = 50. a = a* b;
			Console.WriteLine (a);

			Console.WriteLine ("\nИзползване на ++ ");
			a ++ ; // a = a+1,  a= 50+1=51
			Console.WriteLine (a);

			Console.WriteLine ("Стандартно деление : " + (7 / 3).ToString() );  // отговора е цялата част 2 
			Console.WriteLine ("Остатък от деление : " + (7 % 3).ToString() );  // отговора е  1  1 /3 = 0,3333 .... 
		}
	}
}
		
