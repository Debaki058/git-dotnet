using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    public interface IPizza //productA
    {
        string Eat();
    }


    class VegPizza : IPizza   //concrete product1A              
    {
        public string Eat()
        {
            return "Eating veg pizza";
        }

    }

    class NonVegPizza : IPizza //nonconcrete product2A
    {
        public string Eat()
        {
            return "Eating Non-veg pizza";
        }

    }
    public interface IBurger //productB
    {
        string Eat();
    }


    class VegBurger : IBurger       //concrete product1B
    {
        public string Eat()
        {
            return "Eating veg burger";
        }

    }

    class NonVegBurger : IBurger //concrete product2B
    {
        public string Eat()
        {
            return "Eating Non-veg burger";
        }

    }


    public interface IChef  //Factory
    {
        IPizza PreparePizza();
        IBurger PrepareBurger();

    }

    class VegChef : IChef //concrete factoryclass
    {
        public IPizza PreparePizza()
        {
            return new VegPizza();
        }

        public IBurger PrepareBurger()
        {
            return new VegBurger();
        }

    }

    class NonVegChef : IChef //concrete factoryclass
    {
        public IPizza PreparePizza()
        {
            return new NonVegPizza();
        }

        public IBurger PrepareBurger()
        {
            return new NonVegBurger();
        }

    }

    class Waiter //client class
    {
        private IChef FoodFactory;
        public Waiter(string preference)
        {
            if (preference == "veg")
                FoodFactory = new VegChef();
            else

                FoodFactory = new NonVegChef();
        }

        public IPizza GetPizza() 
        {

            return FoodFactory.PreparePizza();
        }


        public IPizza GetBurger()
        {

            return FoodFactory.PreparePizza();
        }

    }
}
