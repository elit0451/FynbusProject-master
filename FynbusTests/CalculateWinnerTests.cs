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
            Offer o = new Offer("Jan-1", 10, 20, 250, contractor);
            Contractor contractor2 = new Contractor("jan-1", "dasdad", "Thomas Hvidt", "sadad@gadas.com", 1, 2, 2, 1, 4);
            Offer o2 = new Offer("Jan-1", 10, 20, 300, contractor);
            r.AddToList(o);
            r.AddToList(o2);
            Assert.AreEqual(r.GetDifference(), 50);
        }



        [TestMethod]
        public void CanSortRouteByHighestDifferenceAscending()
        {
            CalculateWinner calculateWinner = new CalculateWinner();
            Contractor contractor = new Contractor("jan-1", "Datguy", "Firstguy", "sadad@gadas.com", 1, 2, 2, 3, 4);
            Route r = new Route(1, 1);
            Offer o = new Offer("Jan-1", 10, 20, 250, contractor);
            Contractor contractor2 = new Contractor("jan-1", "Datotherguy", "Otherguy", "otherguy@live.com", 1, 2, 2, 1, 4);
            Offer o2 = new Offer("Jan-1", 10, 20, 300, contractor2);
            Offer o3 = new Offer("Jan-1", 10, 20, 30, contractor);
            Offer o4 = new Offer("Jan-1", 10, 20, 270, contractor2);
            r.AddToList(o);
            r.AddToList(o2);
            Route r2 = new Route(1, 1);
            r2.AddToList(o3);
            r2.AddToList(o4);
            // add to calculatewinner
            calculateWinner.Routes.Add(r);
            calculateWinner.Routes.Add(r2);

            //assert that wrong route is first in unsorted list
            Assert.AreEqual(calculateWinner.Routes[0], r);

            //assert that right route is first in sorted list
            calculateWinner.SortRoutesByPriceDifference();
            Assert.AreEqual(calculateWinner.Routes[1], r);
        }


        //Integration test
        [TestMethod]
        public void CanCalculateWinner()
        {
            CalculateWinner calculateWinner = new CalculateWinner();
        }


    }
}
