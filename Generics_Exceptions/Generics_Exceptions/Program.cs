using System;
using System.Threading.Channels;

namespace Generics_Exceptions
{
    internal class Program
    {
        private static void Main()
        {
            StudentRepository.New.Main();
            
            Helper helper = new Helper();

            char[] input = new[] {'a', 'b', 'c', 'd'};

            foreach (var number in helper.ReverseArray(input))
            {
                Console.Write(number + ", ");
            }

            GenericClass<Helper, TestClass1> genericClass = new GenericClass<Helper, TestClass1>();
            
            genericClass.DisplayParameterTypes();

            Pair<string, int> par1 = new Pair<string, int>("abc", 1);
            Console.WriteLine($"The first value is {par1.GetFirstValue()} and it's a {par1.GetFirstValue().GetType().Name} and the second value is {par1.GetSecondValue()} and it's a {par1.GetSecondValue().GetType().Name}"
            );
            
        }
    }
}
