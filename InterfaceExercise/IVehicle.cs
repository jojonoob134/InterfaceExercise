using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int NumOfWheels { get; set; }
        public int Speed { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

    }
}
