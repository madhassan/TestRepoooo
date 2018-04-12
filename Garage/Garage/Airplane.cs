﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Airplane : Vehicle
    {
        public Airplane(int registrationNo,string color,int nOofwheels,int numberOfengines) : base(registrationNo,color,nOofwheels)
        {
            NumberOfEngines = numberOfengines;
        }
        public int NumberOfEngines { get; set; }
    }
}
