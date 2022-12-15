using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        public int Door { get; set; }
        public bool Windsheild { get; set; }
        public bool Headlights { get; set; }
        public bool Trunk { get; set;}
    }
}
