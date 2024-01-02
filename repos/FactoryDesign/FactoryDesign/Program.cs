/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter();
            IPizza pizza = waiter.GetPizza("NonVeg");
            Console.WriteLine(pizza.Eat());
            Console.ReadLine();
        }
    }
} */


using FactoryDesign;
using System;

namespace FactoryDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Waiter waiter = new Waiter("veg");
            IPizza pizza = waiter.GetPizza();
            Console.WriteLine(pizza.Eat());
            Console.ReadLine();
           
        }
    }
}