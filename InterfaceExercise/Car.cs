using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle,ICompany
    {
        public bool HasScrean { get; set; }

        public int GasMileage { get; set; }
        public int NumOfWheels { get; set; }
        public int Speed { get ; set  ; }
        public string Name { get ; set ; }
        public string Color { get ; set ; }
        string ICompany.Logo { get ; set ; }
        int ICompany.Size { get ; set ; }
    }
}
