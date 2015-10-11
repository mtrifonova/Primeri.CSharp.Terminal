using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// bool _b = true; // този тип променливи има само 2 стойности - true или false. Удобни за правене на проверки 
			// bool test = 5 > 10;

			int[] _i = new int[] { 4, 3, 2 };

			Console.Write ("Въведи кой от 3-те елемента искаш да видиш: ");

			int _ui = Convert.ToInt32(Console.ReadLine());  // индекс за това кой елемент от масива искаме

			bool _check01 = _ui <= _i.Length;    // проверка 

			bool _check02 = _ui > 0;               // проверка 


			Console.WriteLine ( _i [_ui - 1 ] );    // пишем -1 понеже C# броенето е от 0 

			Console.WriteLine (_check01);

			Console.WriteLine (_check02);	
		}
	}
}
