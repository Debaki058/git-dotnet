using System;
namespace Inhertance
{
    class Program
    {
         public static void Main(String[] args)
        { 
            Personal ram = new Personal();
            string msg =  ram.speak();
            Console.WriteLine(msg);
            ram.eat();
            ram.run();
            Console.ReadKey();
        }
    }
}
