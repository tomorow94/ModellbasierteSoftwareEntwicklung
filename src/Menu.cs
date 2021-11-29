﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModellbasierteSoftwareEntwicklung.src.GenericsExamples;

namespace ModellbasierteSoftwareEntwicklung.src
{
	internal class Menu
	{
		internal void PrintMenu()
		{
			Console.WriteLine();
			Console.WriteLine("1 : print 'Check' examples");
			Console.WriteLine("2 : print 'Swapper' examples");
			Console.WriteLine("0 : exit");
			Console.WriteLine();
		}

		internal char HandleMenuInput()
		{
			char c = Console.ReadKey().KeyChar;
			switch (c)
			{
				case '1':
					CheckExamples.Print();
					break;
				case '2':
					SwapExamples.Print();
					break;
				default:
					break;
			}

			return c;
		}
	}
}