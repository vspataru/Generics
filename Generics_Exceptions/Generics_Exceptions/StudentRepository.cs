using System;
using System.Linq;

namespace Generics_Exceptions
{
	using System.Collections.Generic;
	using Models;

	public class StudentRepository
	{
		public static StudentRepository New => new StudentRepository();

		private List<Student> _students = new List<Student>();

		public void Main()
		{
			try
			{
				Add("Vlad", "Spataru");
				Add("Alex", "Grigoras");
				Add("Dorin", "Constantin");
				Add("Monica", "Stefan");
			}
			catch (ListFullException e)
			{
				Console.WriteLine("List is full! Please remove a student before trying again");
			}
			try
			{
				GetById(1);
			}
			catch (StudentDoesNotExistException e)
			{
				Console.WriteLine("The student with this ID does not exist");
			}
		}

		public void Add(string firstName, string lastName)
		{
			var newStudent = new Student {FirstName = firstName, LastName = lastName, Id = GenerateUniqueStudentId()};
			if (_students.Count==3)
			{
				throw new ListFullException();
			}

			_students.Add(newStudent);

		}

		public Student GetById(int id)
		{
			if (StudentIdExists(id))
			{
				return _students.First(student => student.Id == id);
			}

			throw new StudentDoesNotExistException();
		}

		public List<Student> GetAll()
		{
			return _students;
		}

		public void Update(int id, Student newStudent)
		{
			var studentToUpdate = GetById(id);

			studentToUpdate.FirstName = newStudent.FirstName;
			studentToUpdate.LastName = newStudent.LastName;
		}

		public void Remove(int id)
		{
			_students.Remove(GetById(id));
		
		}

		public void Remove(Student student)
		{
			if (_students.Contains(student))
			{
				_students.Remove(student);
			}
		}

		private bool StudentIdExists(int newStudentId)
		{
			return _students.Any(existingStudent => existingStudent.Id == newStudentId);
		}

		private int GenerateUniqueStudentId()
		{
			var uniqueId = new Random().Next(1000);

			return StudentIdExists(uniqueId) ? GenerateUniqueStudentId() : uniqueId;
		}
	}
}