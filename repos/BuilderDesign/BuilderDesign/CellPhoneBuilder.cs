using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesign
{
    public class CellPhoneBuilder
    {
        private string os;
        private string processor;
        private double screenSize;
        private int battery;
        private int camera;

        public CellPhone Getphone()
        {
            return new CellPhone(os, processor, screenSize, battery, camera);
        }

        public CellPhoneBuilder SetOS(string os)
        {
            this.os = os;
            return this;
        }

        public CellPhoneBuilder SetProcessor(string processor)
        {
            this.processor = processor;
            return this;
        }

        public CellPhoneBuilder SetScreenSize(double screenSize)
        {
            this.screenSize = screenSize;
            return this;
        }

        public CellPhoneBuilder SetBattery(int battery)
        {
            this.battery = battery;
            return this;
        }

        public CellPhoneBuilder SetCamera(int camera)
        {
            this.camera = camera;
            return this;
        }
    }
}
