using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RoomLights roomLights = new RoomLights();
            SoundSystem soundSystem = new SoundSystem();
            Television television = new Television();
            HomeTheatreFacade facade = new HomeTheatreFacade(roomLights, soundSystem, television);

            // Using the facade to watch and stop a movie
            facade.watchMovie();
            facade.stopWatchingMovie();
            Console.ReadLine();

        }
    }
}
