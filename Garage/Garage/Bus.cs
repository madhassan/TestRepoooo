using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Bus : Vehicle
    {
        public Bus(string registrationNo, string color, int nOofwheels, int noOfseats) : base(registrationNo, color, nOofwheels)
        {
            NumberOfSeats = noOfseats;
        }
        public int NumberOfSeats { get; set; }
    }
}
