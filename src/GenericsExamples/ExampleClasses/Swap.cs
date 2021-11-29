namespace ModellbasierteSoftwareEntwicklung.src.GenericsExamples.ExampleClasses
{
	internal static class Swapper
	{
		internal static void SwapIt<T>(ref T a, ref T b)
		{
			T temp;
			temp = a;
			a = b;
			b = temp;
		}
	}
	
}
