using System;

namespace Generics_Exceptions
{
	public class Helper
	{
		public T[] ReverseArray<T>(T[] input)
		{
			T[] reversed = new T[input.Length];

			for (var i = input.Length - 1; i >= 0; i--)
			{
				reversed[input.Length - 1 - i] = input[i];
			}
			return reversed;
		}
	}
}