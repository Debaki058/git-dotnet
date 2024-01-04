using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class SoundSystem
    {
        public void switchOnSoundSystem()
        {
            Console.WriteLine("Sound System is On");
        }

        public void switchOffSoundSystem()
        {
            Console.WriteLine("Sound System is Off");
        }
    }
}
