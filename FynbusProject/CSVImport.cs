﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public enum fileType
{
    OFFERS,
    CONTRACTORS,
    ROUTES
}
namespace FynbusProject
{
    public class CSVImport
    {

        public List<Offer> ListOfOffers
        { get; private set; }
        public Dictionary<string, Contractor> ListOfContractors { get; private set; }
        public Dictionary<int, Route> ListOfRoutes { get; private set; }

        private static CSVImport instance;

        private CSVImport()
        {
            ListOfOffers = new List<Offer>();
            ListOfContractors = new Dictionary<string, Contractor>();
            ListOfRoutes = new Dictionary<int, Route>();
        }

        public static CSVImport Instance
        {
            get
            {
                {
                    if (instance == null)
                        instance = new CSVImport();
                }
                return instance;
            }
        }

        public bool Import(string filepath, fileType ft)
        {
            bool importSucessful = false; ;


            switch (ft)
            {
                case fileType.OFFERS:
                    importSucessful = ImportOffer(filepath);
                    break;
                case fileType.CONTRACTORS:
                    importSucessful = ImportContractor(filepath);
                    break;
                case fileType.ROUTES:
                    importSucessful = ImportRoute(filepath);
                    break;
                default: throw new Exception("File Type doesn't exist!");
            }
            return importSucessful;
        }

        private bool ImportRoute(string filepath)
        {
            bool isRouteData = false;

            //Get all the info from the CSV file
            string[] data = File.ReadAllLines(filepath, Encoding.GetEncoding("iso-8859-1"));


            //Check if this is a header for the Route
            if (data[0].Contains("Garanti-vogn nr.;Vogntype"))
            {
                isRouteData = true;
            }

            if (isRouteData == true)
            {
                //Go through every row on the CSV file data after the headers (i=1)
                for (int i = 1; i < data.Length; i++)
                {
                    string row = data[i];
                    //Get every collumn in that row
                    string[] collumns = row.Split(';');

                    int routeNr = int.Parse(collumns[0]);
                    int vehType = int.Parse(collumns[1]);

                    Route newRoute = new Route(routeNr, vehType);
                    ListOfRoutes.Add(routeNr, newRoute);
                }
            }

            if (ListOfRoutes.Count <= 0)
            {
                isRouteData = false;
            }

            return isRouteData;
        }

        private bool ImportContractor(string filepath)
        {
            bool isContractorData = false;

            //Get all the info from the CSV file
            string[] data = File.ReadAllLines(filepath, Encoding.GetEncoding("iso-8859-1"));

            //Check if this is a header for the Contractor
            if (data[0].Contains("Nummer;Navn;Virksomhedsnavn;BrugerID;Vedståelse v2;Vedståelse v3;Vedståelse v5;Vedståelse v6;Vedståelse v7;"))
            {
                isContractorData = true;
            }

            if (isContractorData == true)
            {
                //Go through every row on the CSV file data after the headers (i=1)
                for (int i = 1; i < data.Length; i++)
                {
                    string row = data[i];
                    //Get every collumn in that row
                    string[] collumns = row.Split(';');

                    string number = collumns[0];
                    string name = collumns[1];
                    string companyName = collumns[2];
                    string email = collumns[3];
                    int type2 = int.Parse(collumns[4]);
                    int type3 = int.Parse(collumns[5]);
                    int type5 = int.Parse(collumns[6]);
                    int type6 = int.Parse(collumns[7]);
                    int type7 = int.Parse(collumns[8]);


                    Contractor newContractor = new Contractor(number, companyName, name, email, type2, type3, type5, type6, type7);
                    ListOfContractors.Add(email, newContractor);
                }
            }

            if (ListOfContractors.Count <= 0)
            {
                isContractorData = false;
            }

            return isContractorData;
        }

        private bool ImportOffer(string filepath)
        {
            bool isOfferData = false;

            //Get all the info from the CSV file
            string[] data = File.ReadAllLines(filepath, Encoding.GetEncoding("iso-8859-1"));

            //Check if this is a header for the offers
            if (data[0].Contains("Nummer;Garantivognsnummer;Pris;navn;Virksomhedsnavn;BrugerID;Rutenummer prioritet;Entreprenør prioriter"))
            {
                isOfferData = true;
            }

            if (isOfferData == true)
            {
                //Go through every row on the CSV file data after the headers (i=1)
                for (int i = 1; i < data.Length; i++)
                {
                    string row = data[i];
                    //Get every collumn in that row
                    string[] collumns = row.Split(';');

                    string offerId = collumns[0];
                    int routeNumber = int.Parse(collumns[1]);
                    int hoursAvailable = 10; // ??
                    double price = double.Parse(collumns[2]);
                    string contractorEmail = collumns[5];
                    Contractor contractor = ListOfContractors[contractorEmail];
                    int priority = 10;
                    if (collumns[7] != "")
                    {
                        priority = int.Parse(collumns[7]);
                    }



                    Offer newOffer = new Offer(offerId, ListOfRoutes[routeNumber], hoursAvailable, price, contractor, priority);
                    ListOfOffers.Add(newOffer);
                    ListOfRoutes[routeNumber].AddToList(newOffer);
                }
            }

            if (ListOfOffers.Count <= 0)
            {
                isOfferData = false;
            }

            return isOfferData;
        }

        public bool ClearData()
        {
            bool dataCleared = false;

            ListOfOffers.Clear();
            ListOfContractors.Clear();
            ListOfRoutes.Clear();

            if (ListOfOffers.Count == 0 && ListOfContractors.Count == 0 && ListOfRoutes.Count == 0)
            {
                dataCleared = true;
            }

            return dataCleared;
        }
    }
}
