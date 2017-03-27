using System.Collections.Generic;

namespace FynbusProject
{
    public class Route
    {
        public int RouteNumber { get; private set; }
        public int VehicleType { get; private set; }
        public List<Offer> ListOfOffers { get; private set; }
        public Route(int routeNb, int vehType)
        {
            RouteNumber = routeNb;
            VehicleType = vehType;
            ListOfOffers = new List<Offer>();
        }

        public void AddToList(Offer o)
        {
            ListOfOffers.Add(o);
        }

        public override bool Equals(object obj)
        {
            Route r = (Route)obj;
            return (r.RouteNumber == this.RouteNumber &&
                r.VehicleType == this.VehicleType);
        }
    }
}
