using System.Collections.Generic;

namespace Generics_Exceptions
{
	public class Pair<S,T>
	{

		private S _value1;
		private T _value2;
		
		public Pair(S val1,T val2)
		{
			_value1 = val1;
			_value2 = val2;
		}

		public S GetFirstValue()
		{
			return _value1;
		}
		
		public T GetSecondValue()
		{
			return _value2;
		}
	}
}