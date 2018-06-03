using System;

namespace PrivateObjectStandard
{
	public class ImportantClassInStandard
	{
		public int PublicMethod()
		{
			return 256;
		}

		private int PrivateMethod(int multiplier)
		{
			return 256 * multiplier;
		}
	}
}
