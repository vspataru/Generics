using System;

namespace Generics_Exceptions
{
	public class ListFullException : Exception
	{
		public ListFullException() : base("List has reached the maximum amount of students")
		{
		}
	}
}