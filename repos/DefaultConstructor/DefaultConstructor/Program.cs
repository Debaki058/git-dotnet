using System;

namespace DefaultConstructor
{
    public class Program
    {
        Program() 
        {
            Console.WriteLine("I am Constructor");
        
        }
        static void Main(string[] args)
        {
            Program d = new Program();
        }
    }
}
        