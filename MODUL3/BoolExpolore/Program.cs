using System;

namespace BoolExpolore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// bool _b = true;
			// bool _test = 5 > 10;

			int[] _i = new int[] { 4, 3, 2 };

			Console.WriteLine( " Въведи индекс:  ");

			int _ui = Convert.ToInt32 (Console.ReadLine ());

//			bool _check01 = _ui <= _i.Length;  // правим проверка дали въведената променлива е <= от дължината на масива
//
//			bool _check02 = _ui > 0 ;
//
//			bool _exp01 = _check01 && _check02; // Логическо И то връща стойност истина ако и двете променливи са истина / true/
//
//			bool _exp02 = _check01 || _check02; // Логическо ИЛИ  то връща стойност истина ако поне едната променлива е  истина / true
//
//			bool _exp03 = !_check01;            // Логическо Отрицание.  Ако е лъжа дава истина, ако е истина дава лъжа
//
//			Console.WriteLine ( "Логическо И   :  " + _exp01.ToString() );
//
//			Console.WriteLine (" Логическо ИЛИ :  " + _exp02.ToString() );
//
//			Console.riteLine ( " Отрицание  на : " + _check01.ToString() + ": " + _exp03);
			if (_ui > 0 && _ui <= _i.Length) {
				Console.WriteLine (_i [_ui - 1]);
			} else { if (_ui > _i.Length) {
					Console.WriteLine (
						"индекса е прекалено голям\n\n\n");	}
				
			 if (_ui <= 0 ) {
				
					Console.WriteLine (
						"индекса е прекалено малък\n\n\n");	} }
		}
	}
}	   
