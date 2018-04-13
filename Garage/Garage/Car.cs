using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Car : Vehicle
    {
        public Car(string registrationNo, string color, int nOofwheels, float cylinderVolume) : base(registrationNo, color, nOofwheels)
        {
            CylinderVolume = cylinderVolume;
        }
        public float CylinderVolume { get; set; }
    }
}
