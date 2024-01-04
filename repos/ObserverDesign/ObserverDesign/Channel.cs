
using System;
using System.Collections.Generic;

namespace ObserverDesign
{
    public class Channel
    {
        private List<Subscriber> subs = new List<Subscriber>();
        internal string title;

        public void Subscribe(Subscriber sub)
        {
            subs.Add(sub);
        }

        public void Unsubscribe(Subscriber sub)
        {
            subs.Remove(sub);
        }

        public void NotifySubscribers()
        {
            foreach (Subscriber sub in subs)
            {
                sub.update();
            }
        }

       public void Upload(string title)
        {
            this.title = title;
            NotifySubscribers();
        }
        
    }

}    
