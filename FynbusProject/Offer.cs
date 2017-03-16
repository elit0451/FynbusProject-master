using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FynbusProject
{
    class Offer
    {
        private int _id;
        private int _vehicleType;
        private int _availableHours;

        public Offer(int id, int vehType, int avaHours)
        {
            _id = id;
            _vehicleType = vehType;
            _availableHours = avaHours;
        }
    }
}
