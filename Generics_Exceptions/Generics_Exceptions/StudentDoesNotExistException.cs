using System;

namespace Generics_Exceptions
{
	public class StudentDoesNotExistException : Exception
	{
		public StudentDoesNotExistException() : base("Student not existing in the list")
		{
			
		}
	}
}