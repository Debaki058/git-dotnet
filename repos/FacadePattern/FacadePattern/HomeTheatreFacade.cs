using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
   public class HomeTheatreFacade
    {
        RoomLights  roomLights;
        SoundSystem soundSystem;
        Television television;

        public HomeTheatreFacade(RoomLights roomLights, SoundSystem soundSystem, Television television)
        {
            this.roomLights = roomLights;
            this.soundSystem = soundSystem; 
            this.television = television;   

        }


        public void watchMovie()
        {
            soundSystem.switchOnSoundSystem();
            television.switchOnTV();
            roomLights.lightsDim();

        }

        public void stopWatchingMovie()
        {
            soundSystem.switchOffSoundSystem();
            television.switchOffTV();
            roomLights.lightsBright();
        }


    }
}
