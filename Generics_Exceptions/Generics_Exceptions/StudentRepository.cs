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
            // Your test code here
        }
    }
}
