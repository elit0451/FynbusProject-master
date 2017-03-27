using FynbusProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FynbusTests
{
    [TestClass]
    public class CalculateWinnerTests
    {

        //Unit Tests

        [TestMethod]
        public void CanGetDifferenceOnFirstAndSecondOffers()
        {
            Contractor contractor = new Contractor("jan-1", "dasdad", "Thomas Hvidt", "sadad@gadas.com", 1, 2, 2, 3, 4);
            Route r = new Route(1, 1);
            Offer o = new Offer("Jan-1", 10, 20, 30, contractor);
            Contractor contractor2 = new Contractor("jan-1", "dasdad", "Thomas Hvidt", "sadad@gadas.com", 1, 2, 2, 3, 4);
            Offer o2 = new Offer("Jan-1", 10, 20, 4000, contractor);
            r.AddToList(o);
            r.AddToList(o2);
        }

        //Integration test
        [TestMethod]
        public void CanCalculateWinner()
        {
            CalculateWinner calculateWinner = new CalculateWinner();
        }

    }
}
