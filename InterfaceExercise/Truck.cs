using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public string TowCapacity { get; set; }
        public bool HasPullBar { get; set; }
        public bool Windsheild { get; set; }
        public bool Headlights { get; set; }
        public bool Trunk { get; set; }
        public int Door { get; set; }
        public string Logo { get; set; }
        public string NationOfOrigin { get; set; }

    }
}
