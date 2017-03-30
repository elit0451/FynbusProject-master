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
        public void CanSortRouteByPriceAscending()
        {
            CalculateWinner calculateWinner = new CalculateWinner();
            Contractor contractor = new Contractor("jan-1", "Datguy", "Firstguy", "sadad@gadas.com", 1, 2, 2, 3, 4);
            Route r = new Route(1,2);
            Offer o = new Offer("Jan-1", 1, 20, 250, contractor);
            Contractor contractor2 = new Contractor("jan-1", "Datotherguy", "Otherguy", "otherguy@live.com", 1, 2, 2, 1, 4);
            Offer o2 = new Offer("Jan-1", 1, 20, 300, contractor2);
            Offer o3 = new Offer("Jan-1", 1, 20, 30, contractor);

            r.AddToList(o);
            r.AddToList(o2);
            r.AddToList(o3);
            
            // add to calculatewinner
            calculateWinner.AddToRouteList(r);

            //assert that wrong route is first in unsorted list
            Assert.AreEqual(o.Price, calculateWinner.GetRouteInIndex(0).ListOfOffers[0].Price);

            //assert that right route is first in sorted list
            calculateWinner.SortOffersInRoutesByPriceAscending();
            Assert.AreEqual(o3.Price, calculateWinner.GetRouteInIndex(0).ListOfOffers[0].Price);
        }

        [TestMethod]
        public void CanSortRouteByHighestDifferenceAscending2()
        {
            CalculateWinner calculateWinner = new CalculateWinner();
            Contractor contractor = new Contractor("jan-1", "Datguy", "Firstguy", "sadad@gadas.com", 1, 2, 2, 3, 4);
            Route r = new Route(1, 2);
            Offer o = new Offer("Jan-1", 10, 20, 250, contractor);
            Contractor contractor2 = new Contractor("jan-1", "Datotherguy", "Otherguy", "otherguy@live.com", 1, 2, 2, 1, 4);
            Offer o2 = new Offer("Jan-1", 10, 20, 300, contractor2);
            Offer o3 = new Offer("Jan-1", 10, 20, 30, contractor);
            Offer o4 = new Offer("Jan-1", 10, 20, 270, contractor2);
            r.AddToList(o);
            r.AddToList(o2);
            Route r2 = new Route(2, 2);
            r2.AddToList(o3);
            r2.AddToList(o4);
            // add to calculatewinner
            calculateWinner.AddToRouteList(r);
            calculateWinner.AddToRouteList(r2);

            calculateWinner.SortOffersInRoutesByPriceAscending();
            //assert that wrong route is first in unsorted list
            Assert.AreEqual(r.RouteNumber, calculateWinner.GetRouteInIndex(0).RouteNumber);
 
            //assert that right route is first in sorted list
            calculateWinner.SortRoutesByPriceDifference();
            Assert.AreEqual(r2.RouteNumber, calculateWinner.GetRouteInIndex(0).RouteNumber);
        }

    
        //Integration test
        [TestMethod]
        public void CanCalculateWinner()
        {
            CalculateWinner calculateWinner = new CalculateWinner();
        }


    }
}
