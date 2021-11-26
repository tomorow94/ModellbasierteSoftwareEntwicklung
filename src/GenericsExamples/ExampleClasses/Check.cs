using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModellbasierteSoftwareEntwicklung.GenericsExamples
{
	internal class Check<T>
	{
		public bool Compare(T a, T b)
		{
			if (a != null && a.Equals(b))
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
