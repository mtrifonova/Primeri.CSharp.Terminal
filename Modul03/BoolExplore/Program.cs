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

			if (_ui > 0 && _ui <= _i.Length) {

				Console.WriteLine (_i [_ui - 1]);
			} else { if ( _ui > _i.Length ) { Console.WriteLine("Индекса е прекалено голям\n\n"); } 
				if ( _ui <= 0 ) { Console.WriteLine ("Индекса е прекалено малък\n\n");  }
			}

//			bool _check01 = _ui <= _i.Length;    // проверка на _ui дали е по-малко от дължината 3 или = 3
//		 
//			bool _check02 = _ui > 0;               // проверка 
//
//			bool _exp01 = _check01 && _check02;  // Логическо И -&&  трябва и двете да са истина
//
//			bool _exp02 = _check01 || _check02;  // Логическо Или -|| поне едното да е  истина
//
//			bool _exp03 = !_check01;   // Отрицание
//
//			Console.WriteLine ("Логическо И && :  " + _exp01.ToString());
//
//			Console.WriteLine ("Логическо Или -||  :  " + _exp02.ToString());
//
//			Console.WriteLine (" Отрицание  :  " + _exp03.ToString());

			//Console.WriteLine ( _i [_ui - 1 ] );    // пишем -1 понеже C# броенето е от 0 

			//Console.WriteLine (_check01);

			//Console.WriteLine (_check02);	
		}
	}
}
