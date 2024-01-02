using System;


namespace Multicast_Delegate_Demo //multiple Delegate
{
    public delegate void Calculation(int a , int b );
    
    internal class Program
    {
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is :{0}",result);
        }

        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction result is :{0}", result);
        }

        public static void Multification(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multification result is :{0}", result);
        }
        public static void Divison(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division result is :{0}", result);
        }
        public static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.Addition);
            obj.Invoke(10, 20);
            Calculation obj1 = new Calculation(Program.Subtraction);
            obj1.Invoke(10, 20);
            Calculation obj2 = new Calculation(Program.Multification);
            obj2.Invoke(10, 20);
            Calculation obj3 = new Calculation(Program.Divison);
            obj3.Invoke(10, 20);


            //obj = Subtraction;
           // obj(20, 10);
           // obj = Multification;
           // obj(20, 10);
           // obj = Divison;
           // obj(20, 10);
            Console.ReadLine();


        }
    }
}


