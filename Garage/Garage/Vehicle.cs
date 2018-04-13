using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Vehicle
    {
        public Vehicle(string registrationNo, string color, int numberOfwheels)
        {
            RegistrationNumber = registrationNo;
            Color = color;
            NumberofWheels = numberOfwheels;
        }

        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int NumberofWheels { get; set; }
    }
}
