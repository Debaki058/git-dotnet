using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IEmployee
    {
      void show();//interface vira jati pani member hunxa bydefault abstract r public banidinxa// 

    }

    class PartTimeEmployee : IEmployee
    {
        public void show() 
        {
            Console.WriteLine("This methos of IEmployee  interface!!");
        }
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            PartTimeEmployee employee = new PartTimeEmployee();
            employee.show();
            Console.ReadLine();
        }
    }
}
