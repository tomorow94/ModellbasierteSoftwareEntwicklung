using ModellbasierteSoftwareEntwicklung.GenericsExamples;
using ModellbasierteSoftwareEntwicklung.src.GenericsExamples.ExampleClasses;

namespace ModellbasierteSoftwareEntwicklung.src.GenericsExamples
{
	internal class CheckExamples
	{
		public static void Print()
		{
			//Check.cs examples
			CheckInt();
			CheckString();
			CheckBool();
			CheckActions();
			CheckLists();
			CheckMyEmptyClass();
			Console.WriteLine("|---------------------------------|");
		}

		private static void CheckInt()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("check integers:");
			var checkInt = new Check<int>();
			Console.WriteLine("1 & 3");
			Console.WriteLine(checkInt.Compare(1, 3));
			Console.WriteLine("2 & 2");
			Console.WriteLine(checkInt.Compare(2, 2));
		}

		private static void CheckString()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("check strings:");
			var checkString = new Check<string>();
			Console.WriteLine("hi & Hi");
			Console.WriteLine(checkString.Compare("hi", "Hi"));
			Console.WriteLine("Hi & Hi");
			Console.WriteLine(checkString.Compare("Hi", "Hi"));
			Console.WriteLine("hi & ho");
			Console.WriteLine(checkString.Compare("hi", "ho"));
		}

		private static void CheckBool()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("check bool:");
			var checkBool = new Check<bool>();
			Console.WriteLine("true & false");
			Console.WriteLine(checkBool.Compare(true, false));
			Console.WriteLine("true & true");
			Console.WriteLine(checkBool.Compare(true, true));
			Console.WriteLine("false & false");
			Console.WriteLine(checkBool.Compare(false, false));
		}

		private static void CheckActions()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("check actions<int>:");
			Check<Action<int>> check = new Check<Action<int>>();
			Action<int> printAction1 = i => Console.WriteLine(i);
			Action<int> printAction2 = i => Console.WriteLine(i);
			Console.WriteLine("Action<int> printAction1 = i => Console.WriteLine(i);");
			Console.WriteLine("Action<int> printAction2 = i => Console.WriteLine(i);");
			Console.WriteLine("printAction1 & printAction1");
			Console.WriteLine(check.Compare(printAction1, printAction1));
			Console.WriteLine("printAction1 & printAction2");
			Console.WriteLine(check.Compare(printAction1, printAction2));
			Console.WriteLine("printAction1 & i => Console.WriteLine(i)");
			Console.WriteLine(check.Compare(printAction1, i => Console.WriteLine(i)));
			Console.WriteLine("i => Console.WriteLine(i) & i => Console.WriteLine(i)");
			Console.WriteLine(check.Compare(i => Console.WriteLine(i), i => Console.WriteLine(i)));
		}

		private static void CheckLists()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("|Check Lists Preparation Info|");
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
			Console.WriteLine("List<int> (sorted):");
			var numberListSorted = numberList;
			numberListSorted.Sort();
			foreach (var element in numberListSorted)
			{
				Console.WriteLine("list entry: value {0} - type {1}",
					element, element.GetType());
			}
			
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("check Lists:");
			var check = new Check<List<int>>();
			Console.WriteLine("List<int> & List>int>");
			Console.WriteLine(check.Compare(numberList, numberList));
			Console.WriteLine("List<int>1 & List<int> (sorted)");
			Console.WriteLine(check.Compare(numberList, numberListSorted));
			Console.WriteLine("List<int> (sorted) & List<int> (sorted)");
			Console.WriteLine(check.Compare(numberListSorted, numberListSorted));
		}

		private static void CheckMyEmptyClass()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("check MyEmptyClass:");
			var check = new Check<MyEmptyClass>();
			Console.WriteLine("MyEmptyClass has no special functionality");
			Console.WriteLine(" - Code of MyEmptyClass - ");
			Console.WriteLine("internal class MyEmptyClass");
			Console.WriteLine("{");
			Console.WriteLine("}");
			Console.WriteLine(" - Declaration of variables - ");
			Console.WriteLine("var class1 = new MyEmptyClass();");
			Console.WriteLine("var class2 = new MyEmptyClass();");
			var class1 = new MyEmptyClass();
			var class2 = new MyEmptyClass();
			Console.WriteLine(" - the checks - ");
			Console.WriteLine("class1 & class1");
			Console.WriteLine(check.Compare(class1, class1));
			Console.WriteLine("class1 & class2");
			Console.WriteLine(check.Compare(class1, class2));
			Console.WriteLine("class2 & class2");
			Console.WriteLine(check.Compare(class2, class2));
		}
	}
}
