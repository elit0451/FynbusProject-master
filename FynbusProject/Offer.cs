namespace FynbusProject
{
    public class Offer
    {
        public string Id { get; private set; }
        public int RouteNumber { get; private set; }
        public int AvailableHours { get; private set; }
        public double Price { get; private set; }
        public Contractor OfferContractor { get; private set; }
        public int Priority { get; private set; }

        public Offer(string id, int routeNumber, int avaHours, double price, Contractor cont, int contPriority)
        {
            Id = id;
            RouteNumber = routeNumber;
            AvailableHours = avaHours;
            Price = price;
            OfferContractor = cont;
            Priority = contPriority;
        }
    }
}