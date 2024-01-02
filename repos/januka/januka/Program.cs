using System;


namespace januka
{
    public class Program 
    {
        static void Main(string[] args)
        {

            Mobile1 m= new Mobile1();
            m.price = 10000;
            m.storage = "8gb Ram";
            m.color = "black";
            Console.WriteLine(m.price);
            Console.WriteLine(m.storage);
            Console.WriteLine(m.color);
            Console.ReadKey();
            m.calling();
            m.chatting();
            m.Music();
        }
    }
}
