/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
   public interface IPizza //product
    {
        string Eat();
    }


    class VegPizza : IPizza                  //product ko concrete implementation ho veg r nonveg pizza//
    {
        public string Eat()
        {
            return "Eating veg pizza";
        }
  
    }

    class NonVegPizza : IPizza
    {
        public string Eat()
        {
            return "Eating Non-veg pizza";
        }

    }

    public interface IPizzaChef  //Factory
    {
        IPizza PreparePizza();

    }

    class VegPizzaChef : IPizzaChef
    {
        public IPizza PreparePizza()
        {
            return new VegPizza();
        }
        
    }

    class  NonVegPizzaChef : IPizzaChef
    {
        public IPizza PreparePizza()
        {
            return new NonVegPizza();
        }

    }


    class Waiter // client
    {
        public IPizza GetPizza(string type) 
        {

            IPizzaChef chef;//IPizzaChef chai factory method ko implement gareko  ho
            switch (type)
            {
                case "Veg":
                    chef = new VegPizzaChef();
                    break;
                default:
                    chef = new NonVegPizzaChef();
                    break;
            }
            return chef.PreparePizza();

        }
    }

}  */
