using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GENERIC_METHODS
{
    class Example
    {
        public static bool Check<T>(T a, T b)
        {
            bool c =  a.Equals(b);
            return c;
        }
       
            
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Example.Check(50, 50));
            Console.WriteLine(Example.Check("ABC", "50"));
            Console.WriteLine(Example.Check(40.5, 50.00));
            Console.ReadKey();
        }
    }
}
