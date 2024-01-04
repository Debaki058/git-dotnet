using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesign
{
    public class Subscriber
    {
        private string name;
        Channel channel = new Channel();

        public Subscriber(String name)
        {
            this.name = name;
        }

        public void update()
        {
            Console.WriteLine("Hey" + name + " Video Uploaded :" + channel.title);
        }


        public void subscribeChannel(Channel ch) 
        { 
            channel = ch;
        }
    }
}
