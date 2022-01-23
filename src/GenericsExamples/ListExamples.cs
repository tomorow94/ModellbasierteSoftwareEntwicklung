using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellbasierteSoftwareEntwicklung.src.GenericsExamples
{
	internal class ListExamples
	{
		public static void Print()
		{
			Console.WriteLine("");
			PrintListExample1();
			Console.WriteLine("|---------------------------------|");
		}

		private static void PrintListExample1()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("List<int>:");

			// Creating a list
			// using List<T> class containing integer values
			List<int> numberList = new List<int>();
			// adding integer values to the list
			numberList.Add(13);
			numberList.Add(37);
			numberList.Add(42);
			numberList.Add(20);
			numberList.Add(22);
			
			foreach (var element in numberList)
			{
				Console.WriteLine("list entry: value {0} - type {1}",
					element, element.GetType());
			}

			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("List<int> (sort):");
			numberList.Sort();
			foreach (var element in numberList)
			{
				Console.WriteLine("list entry: value {0} - type {1}",
					element, element.GetType());
			}


			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("List<string>:");

			// using List<T> class containing strings
			List<string> authors = new List<string>();
			// adding strings to the list
			authors.Add("Hermann Hesse");
			authors.Add("Erich Kästner");
			authors.Add("Dietrich Faber");
			authors.Add("Richard David Precht");
			authors.Add("Stephen King");
			authors.Add("Ken Follet");

			foreach (var element in authors)
			{
				Console.WriteLine("list entry: value {0} - type {1}",
					element, element.GetType());
			}

			Console.WriteLine();
		}
	}
}