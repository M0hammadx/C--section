using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Device:Tree
    {
        string DeviceName;
        private string deviceType;

        public Device(string v)
        {
            this.deviceType = v;
        }

        public string DeviceName1 { get => DeviceName; set => DeviceName = value; }
        public string DeviceType { get => deviceType; set => deviceType = value; }
    }
}
