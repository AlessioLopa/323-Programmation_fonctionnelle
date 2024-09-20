using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Rando
{
    internal class Trackpoint
    {
        public Trackpoint(double latitude, double longitude, double elevatiion)
        {
            _latitude = latitude;
            _longitude = longitude;
            _elevatiion = elevatiion;
        }

        public double _latitude { get; set; }
        public double _longitude { get; set; }
        public double _elevatiion { get; set; }
    }
}
