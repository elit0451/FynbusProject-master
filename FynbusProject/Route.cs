using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FynbusProject
{
    class Route
    {
        private int _routeNumber;
        private int _vehicleType;

        public Route(int routeNb, int vehType)
        {
            _routeNumber = routeNb;
            _vehicleType = vehType;
        }
    }
}
