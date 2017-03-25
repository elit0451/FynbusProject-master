﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FynbusProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            new FynbusProject.Program().Run();
        }

        private void Run()
        {
            string filepathRoutes = @"C:\Users\Kast\Desktop\Fynbus\Flexcel_Fynbus\Flex-Sortering 1.02\RouteNumbers.csv";
            string filepathOffers = @"C:\Users\Kast\Desktop\Fynbus\Flexcel_Fynbus\FakeData_Tests\Test med 3 bud til samme rute\Tilbud_FakeData.csv";
            string filepathContractors = @"C:\Users\Kast\Desktop\Fynbus\Flexcel_Fynbus\FakeData_Tests\Test med 3 bud til samme rute\Stamoplysninger_FakeData.csv";


            CSVImport.Instance.Import(filepathRoutes, fileType.ROUTES);
            CSVImport.Instance.Import(filepathContractors, fileType.CONTRACTORS);
            CSVImport.Instance.Import(filepathOffers, fileType.OFFERS);

            Route route = CSVImport.Instance.ListOfRoutes[2];

            Console.WriteLine("routenr: " + route.RouteNumber + " OFFER ID: " + route.ListOfOffers[0].Id + " CONTRACTOR " + route.ListOfOffers[0].OfferContractor.EmailAddress + " VEH T2 : " + route.ListOfOffers[0].OfferContractor.TypeV2);

            Console.ReadKey();
        }
    }
}
