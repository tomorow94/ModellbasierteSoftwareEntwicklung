using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellbasierteSoftwareEntwicklung.src.GenericsExamples
{
	internal class DictionaryExamples
	{
		public static void Print()
		{
			Console.WriteLine("");
			PrintIntegerStringDictionary();
			PrintStringStringDictionary();
			Console.WriteLine("|---------------------------------|");
		}

		private static void PrintIntegerStringDictionary()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("Dictionary<int, string>:");

			// Creating a dictionary
			// using Dictionary<TKey,TValue> class
			Dictionary<int, string> myDict1 =
				new Dictionary<int, string>();

			// Adding key/value pairs 
			// in the Dictionary
			// Using Add() method
			myDict1.Add(1123, "Welcome");
			myDict1.Add(1124, "to");
			myDict1.Add(1125, "GeeksforGeeks");

			foreach (KeyValuePair<int, string> ele1 in myDict1)
			{
				Console.WriteLine("{0} and {1}",
					ele1.Key, ele1.Value);
			}

			Console.WriteLine();
		}

		private static void PrintStringStringDictionary()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("Dictionary<string, string>:");

			// Creating another dictionary
			// using Dictionary<TKey,TValue> class
			// adding key/value pairs without
			// using Add method
			Dictionary<string, string> myDict2 =
				new Dictionary<string, string>()
				{
					{ "a.1", "Dog" },
					{ "a.2", "Cat" },
					{ "a.3", "Pig" }
				};

			foreach (KeyValuePair<string, string> ele2 in myDict2)
			{
				Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
			}
		}
	}
}
