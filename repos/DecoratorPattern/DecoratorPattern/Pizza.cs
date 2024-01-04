using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
   public interface IPizza
    {
        void prepare();
    }

    class BasePizza : IPizza 
    {

        public void prepare()
        {
            Console.WriteLine("pizza prepared");
        }
    }

    public abstract class PizzaDecorator : IPizza // sabai decorator ko lagi base class ho
    {
        private  IPizza  _pizza;

        protected PizzaDecorator(IPizza pizza) 
        {
            _pizza = pizza;
        }

        public virtual void prepare()
        {

            _pizza.prepare();
        }



    }

    public class PepperoniPizza : PizzaDecorator
    {
        public PepperoniPizza (IPizza pizza) : base(pizza)
        {

        }

        public override void prepare()
        {
            base.prepare();
            Console.WriteLine("Adding Pepperoni Topping");
        }
    }


    public class CapsicumPizza : PizzaDecorator
    {
        public CapsicumPizza(IPizza pizza) : base(pizza)
        {

        }

        public override void prepare()
        {
            base.prepare();
            Console.WriteLine("Adding Capsicum Topping");
        }
    }


    public class OninePizza : PizzaDecorator
    {
        public OninePizza(IPizza pizza) : base(pizza)
        {

        }

        public override void prepare()
        {
            base.prepare();
            Console.WriteLine("Adding Onion Topping");
        }
    }





}
