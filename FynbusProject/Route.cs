namespace FynbusProject
{
    public class Route
    {
        public int RouteNumber { get; private set; }
        public int VehicleType { get; private set; }

        public Route(int routeNb, int vehType)
        {
            RouteNumber = routeNb;
            VehicleType = vehType;
        }
    }
}
