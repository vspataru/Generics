namespace Generics_Exceptions.Models
{
	public class Student
	{
		public int Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public override string ToString()
		{
			return $"Id: {Id}, First Name: {FirstName}, Last Name: {LastName}";
		}
	}

}
