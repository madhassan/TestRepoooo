using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Mopeds : Vehicle
    {
   
        public Mopeds(string registrationNo, string color, int numberOfwheels, int padels) : base(registrationNo, color, numberOfwheels)
        {
            Padels = padels;
        }
        
        public override string ToString()
        {
            return base.ToString() + "Padels" + Padels;
        }


        public int Padels { get; set; }
    }
}
