﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class RoomLights
    {
        public void lightsDim()
        {
            Console.WriteLine("Light dim");
        }

        public void lightsBright() 
        {
            Console.WriteLine("Light bright");
        }
    }
}
