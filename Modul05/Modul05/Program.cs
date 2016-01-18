using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			//Дефиниции

			string usercomand = "";

			//Потребителски команди
			do {
				Console.Write ("$ ");	usercomand = Console.ReadLine ();  //Console.Readline -това е метод който връща стринг; Console.Write - това е метод който не връща нищо

				if (usercomand.Contains("cmd01")) cmd01 (usercomand);
				if (usercomand.Contains("cmd02"))  Console.WriteLine(cmd02 (usercomand));

			} while (usercomand != "exit");

		}
		//Само да се изпълнят 
		public static void cmd01 ( string  _input)  // test - името на метода, void- отговаря за това какво ще върнем в метода. Приемаме че потребителя ще въведе команда cmd01 5 > която връща 5^2  . 5*5
		{
			// Слагаме try{ }catch{} за да се защитим от потребителски грешки
			try{
			double _temp=0;
		
				if (double.TryParse (_input.Split(' ')[1],  out _temp ) )  // чрез input.Split(' ')[1] се разбива командата cmd01 5 на 2 като ще вземем втората част от нея като това отиде в _temp
					{
					Console.WriteLine("\nРезултат от " + _temp.ToString() + "^2:" + (_temp * _temp).ToString());
				}
				
			}catch { 
			}
		}


		public static int  cmd02 ( string  _input)  //  string input - вземаме командата жт потребителя, static - статична променлива
		{

			int _temp=0;

			if (int.TryParse (_input.Split(' ')[1],  out _temp ) ) // взимаме [1] втората ст-ст от нея след шпацията -  Пример  cmd02 5 > 5*5*5
			{
				_temp = _temp*_temp*_temp;
			}

			return _temp;
		}


		//Да върнат параметри 
	}

}
