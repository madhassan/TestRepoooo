using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string registrationNo, string color, int nOofwheels, int length) : base(registrationNo, color, nOofwheels)
        {
            Length = length;
        }
        public int Length { get; set; }
    }
}
