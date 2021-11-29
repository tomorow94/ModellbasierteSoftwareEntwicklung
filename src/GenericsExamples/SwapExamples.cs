using ModellbasierteSoftwareEntwicklung.src.GenericsExamples.ExampleClasses;

namespace ModellbasierteSoftwareEntwicklung.src.GenericsExamples
{
	internal class SwapExamples
	{
		public static void Print()
		{
			//Swapper.cs examples
			SwapIntegers();

			SwapStrings();

			SwapBools();

			SwapActions();

			Console.WriteLine("|---------------------------------|");
		}

		private static void SwapIntegers()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("swap integers:");
			int a = 10;
			int b = 20;
			Console.WriteLine("Before swap: {0}, {1}", a, b);
			Swapper.SwapIt(ref a, ref b);
			Console.WriteLine("After swap: {0}, {1}", a, b);
		}

		private static void SwapStrings()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("swap strings:");
			string a = "Hi";
			string b = "hi";
			Console.WriteLine("Before swap: {0}, {1}", a, b);
			Swapper.SwapIt(ref a, ref b);
			Console.WriteLine("After swap: {0}, {1}", a, b);
		}

		private static void SwapBools()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("swap bool:");
			bool a = true;
			bool b = false;
			Console.WriteLine("Before swap: {0}, {1}", a, b);
			Swapper.SwapIt(ref a, ref b);
			Console.WriteLine("After swap: {0}, {1}", a, b);
		}

		private static void SwapActions()
		{
			Console.WriteLine("|---------------------------------|");
			Console.WriteLine("swap action:");
			Action<int> printAction1 = i => Console.WriteLine(i);
			Action<int> printAction2 = i => Console.WriteLine(i);
			Action<int> a = printAction1;
			Action<int> b = printAction2;
			Console.WriteLine("Before swap: {0}, {1}", a, b);
			Swapper.SwapIt(ref a, ref b);
			Console.WriteLine("After swap: {0}, {1}", a, b);
		}
	}
}
