﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Boat : Vehicle
    {
        public Boat(string registrationNo, string color, int nOofwheels, string fuelType) : base(registrationNo, color, nOofwheels)
        {
            FuelType = fuelType;
        }
        public string FuelType { get; set; }
        
        public override string ToString()
        {
            return base.ToString() + "Fuel Type " + FuelType;
        }
    }
}
