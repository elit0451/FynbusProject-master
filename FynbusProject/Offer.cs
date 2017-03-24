namespace FynbusProject
{
    public class Offer
    {
        public string Id { get; private set; }
        public int VehicleType { get; private set; }
        public int AvailableHours { get; private set; }
        public double Price { get; private set; }

        public Offer(string id, int vehType, int avaHours, double price)
        {
            Id = id;
            VehicleType = vehType;
            AvailableHours = avaHours;
            Price = price;
        }
    }
}