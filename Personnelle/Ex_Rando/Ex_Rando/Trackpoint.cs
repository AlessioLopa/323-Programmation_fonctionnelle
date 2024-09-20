using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Rando
{
    internal class Trackpoint
    {
        public Trackpoint(string latitude, string longitude, string elevatiion)
        {
            _latitude = Convert.ToDouble(latitude);
            _longitude = Convert.ToDouble(longitude);
            _elevatiion = Convert.ToDouble(elevatiion);
        }

        public double _latitude { get; set; }
        public double _longitude { get; set; }
        public double _elevatiion { get; set; }
    }
}
