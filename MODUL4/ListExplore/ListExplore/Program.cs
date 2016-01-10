﻿using System;
using System.Collections.Generic;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			string  _userinput = "";
			List<int> _list = new List<int> ();
			_list.Add (5);
			_list.Add (3);
			_list.Add (9);

			do {
				Console.Write ("?");
			    _userinput = Console.ReadLine ();

				//Добавяне на стойности
				if ( _userinput.ToLower().Contains("add"))
					
			   		{
					try
					{
						int _add=0;
						if ( int.TryParse ( _userinput.Split(' ')[1], out _add ))
						{ 
						_list.Add(_add);
						} 
						Console.WriteLine();
					} catch{}
				}

				// Преглед на List
				if ( _userinput.Contains("show"))
					{
					Console.Write(" Списък: ");
					foreach( int value in  _list )   // създаваме променлива value и казваме да обходи целия масив list и да запише ст-ст в value
						{
						Console.Write ( value.ToString() + "," );
						}
					}
//					{
//						for ( int i = 0; i < _list.Count; i++ )
//						{
//							Console.Write("_List: ");
//							Console.Write(_list[i]);
//						if ( i != _list.Count - 1)   Console.Write( ",");
//						}
								Console.WriteLine();
						


				// размер на list
				if ( _userinput.ToLower().Contains("size"))
					{
					Console.WriteLine("размер на списъка: " + _list.Count.ToString() + "\n" );
					}



			   } while (_userinput != "exit");

			}
		}
	}

				
