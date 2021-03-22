using System;

namespace Generics_Exceptions
{
	public class GenericClass<T, TU> where T : class, new() where TU : ICompare
	{

		public void DisplayParameterTypes()
		{
			Console.WriteLine("First parameter:" + typeof(T).Name);
			Console.WriteLine("Second parameter:" + typeof(TU).Name);
		}
		
		
	}
}