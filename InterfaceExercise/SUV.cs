﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle,ICompany
    {
        public bool CanGoOffRoud { get; set; }
        public int NumOfSeats { get; set; }

        public int NumOfWheels { get; set; }
        public int Speed { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        string ICompany.Logo { get; set; }
        int ICompany.Size { get; set; }
    }
}