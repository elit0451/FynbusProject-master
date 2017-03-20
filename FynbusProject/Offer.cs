using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FynbusProject
{
    class Offer
    {
        public string Id { get; set; }
        public int VehicleType { get; set; }
        public int AvailableHours { get; set; }
        public double Price { get; set; }

        public Offer(string id, int vehType, int avaHours, double price)
        {
            Id = id;
            VehicleType = vehType;
            AvailableHours = avaHours;
            Price = price;
        }
    }
}
