using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MySingleton abac = MySingleton.GetInstance();
            Console.WriteLine("HEllo World..!");
            Console.ReadLine();
        }
    }
}
