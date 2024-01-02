using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class A
    {
        private int atmPIN;

        public int getReturn()
        {
            return atmPIN;
        }


        public void setValue(int pin)
        {
            atmPIN = pin;

        }
    }




    class Program

    {
        static void Main(string[] args)
        {
            A a = new A();
            a.setValue(2058);
            Console.WriteLine(" ATM PIN " + a.getReturn());
            Console.ReadKey();
            
        }

    }
}
            

