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

	    	int  _ui = 0;   //Convert.ToInt32 (Console.ReadLine ());
			string  _input = "0";
			Console.Write ("Моля въведети индекс:   ");
			_input = Console.ReadLine ();
			bool _check01 = int.TryParse (_input, out _ui);
			bool _check02 = _ui <= _i.Length;
			bool _check03 = _ui > 0;

			if ( _check01 && _check02 && _check03) {
				Console.WriteLine (_i [_ui - 1]);
			     }  if (!_check01) {
				     	Console.WriteLine("индекса трябва да е цяло число\n\n\n");	    
		          	}
				
			        if (!_check02 ) {
				
					              Console.WriteLine ("индекса е прекалено голям\n\n\n");	} 
				if (!_check03 ) {

				Console.WriteLine ("индекса е прекалено малък\n\n\n"); } 
			}
		}
}	   
