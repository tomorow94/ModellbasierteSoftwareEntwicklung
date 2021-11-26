using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModellbasierteSoftwareEntwicklung.GenericsExamples;

namespace ModellbasierteSoftwareEntwicklung.src.GenericsExamples
{
	internal class CheckExamples
	{
		public static void Print()
		{
			//Check.cs examples
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("check integers:");
			var checkInt = new Check<int>();
			Console.WriteLine("1 & 3");
			Console.WriteLine(checkInt.Compare(1, 3));
			Console.WriteLine("2 & 2");
			Console.WriteLine(checkInt.Compare(2, 2));
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("check strings:");
			var checkString = new Check<string>();
			Console.WriteLine("hi & Hi");
			Console.WriteLine(checkString.Compare("hi", "Hi"));
			Console.WriteLine("Hi & Hi");
			Console.WriteLine(checkString.Compare("Hi", "Hi"));
			Console.WriteLine("hi & ho");
			Console.WriteLine(checkString.Compare("hi", "ho"));
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("check bool:");
			var checkBool = new Check<bool>();
			Console.WriteLine("true & false");
			Console.WriteLine(checkBool.Compare(true, false));
			Console.WriteLine("true & true");
			Console.WriteLine(checkBool.Compare(true, true));
			Console.WriteLine("false & false");
			Console.WriteLine(checkBool.Compare(false, false));
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
			Console.WriteLine("|---------------------------------|");
		}
	}
}
