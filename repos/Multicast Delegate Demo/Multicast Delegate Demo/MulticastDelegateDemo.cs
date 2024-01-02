/*using System;

namespace Multicast_Delegate_Demo
{
    public delegate void AddNum(int x, int y);
    public delegate void SubNum(int x, int y);

    class MulticastDelegateDemo
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }

        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        public static void Main(string[] args)
        {
            MulticastDelegateDemo demo = new MulticastDelegateDemo();
            AddNum add = demo.Add;
            SubNum sub = demo.Sub;

        

            Console.WriteLine("Calling add method:");
            add(2, 4);

            Console.WriteLine("Calling sub method:");
            sub(6, 3);
            Console.ReadLine();

         
        }
    }
}
*/