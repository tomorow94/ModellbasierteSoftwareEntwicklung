using System;
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
			Console.WriteLine("3 : print 'Dictionary' examples");
			Console.WriteLine("4 : play with your own super generic 'Dictionary'");
			Console.WriteLine("5 : print 'List' examples");
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
				case '3':
					DictionaryExamples.Print();
					break;
				case '4':
					DictionaryPlayground.Start();
					break;
				case '5':
					ListExamples.Print();
					break;
				default:
					break;
			}

			return c;
		}
	}
}
