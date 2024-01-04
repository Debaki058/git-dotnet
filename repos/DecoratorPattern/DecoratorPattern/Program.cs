using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
          IPizza pizza =  new CapsicumPizza(new OninePizza(new PepperoniPizza(new BasePizza())));
           pizza.prepare();
            Console.ReadLine();
        }
    }
}
