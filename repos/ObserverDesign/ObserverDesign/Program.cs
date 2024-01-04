using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
   public class Program
    {
       public static void Main(string[] args)
        {

            Channel telusko = new Channel();

            Subscriber s1 = new Subscriber("Ram");
            Subscriber s2 = new Subscriber("Sita");
            Subscriber s3 = new Subscriber("Gita");
            Subscriber s4 = new Subscriber("Devi");
            Subscriber s5 = new Subscriber("Pratik");   
            Subscriber s6 = new Subscriber("Divya");
            Subscriber s7 = new Subscriber("Puja");
            Subscriber s8 = new Subscriber("Niruta");
            Subscriber s9 = new Subscriber("Nikita");
            Subscriber s10 = new Subscriber("sweata");
            Subscriber s11 = new Subscriber("Niru");
            Subscriber s12 = new Subscriber("Janaki");  
            Subscriber s13 = new Subscriber("sabin");
            Subscriber s14 = new Subscriber("Janak");
            Subscriber s15 = new Subscriber("Lokesh");
            Subscriber s16 = new Subscriber("Tek");
            Subscriber s17 = new Subscriber("Niroj");
            Subscriber s18 = new Subscriber("Nel");
            Subscriber s19 = new Subscriber("Pema");
            Subscriber s20 = new Subscriber("Buddha");


            telusko.Subscribe(s1);
            telusko.Subscribe(s2);
            telusko.Subscribe(s3);
            telusko.Subscribe(s4);
            telusko.Subscribe(s5);
            telusko.Subscribe(s6);
            telusko.Subscribe(s7);
            telusko.Subscribe(s8);
            telusko.Subscribe(s9);
            telusko.Subscribe(s10);
            telusko.Subscribe(s11);
            telusko.Subscribe(s12);   
            telusko.Subscribe(s13);
            telusko.Subscribe(s14);
            telusko.Subscribe(s15);
            telusko.Subscribe(s16);
            telusko.Subscribe(s17);
            telusko.Subscribe(s18);
            telusko.Subscribe(s19);
            telusko.Subscribe(s20);


            s1.subscribeChannel(telusko);
            s2.subscribeChannel(telusko);
            s3.subscribeChannel(telusko);
            s4.subscribeChannel(telusko);
            s5.subscribeChannel(telusko);
            s6.subscribeChannel(telusko);
            s7.subscribeChannel(telusko);
            s8.subscribeChannel(telusko);
            s9.subscribeChannel(telusko);
            s10.subscribeChannel(telusko);
            s11.subscribeChannel(telusko);
            s12.subscribeChannel(telusko);
            s13.subscribeChannel(telusko);
            s14.subscribeChannel(telusko);
            s15.subscribeChannel(telusko);
            s16.subscribeChannel(telusko);
            s17.subscribeChannel(telusko);
            s18.subscribeChannel(telusko);
            s19.subscribeChannel(telusko);
            s20.subscribeChannel(telusko);

            
           telusko.Upload("How to Learn Programming..?");
           Console.ReadLine();

        }
    }
}
