namespace ModellbasierteSoftwareEntwicklung.GenericsExamples
{
	internal class Check<T>// where T : IComparable
	{
		public bool Compare(T a, T b)
		{
			if (a != null && b!= null && a.Equals(b))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
