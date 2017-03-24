using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public enum fileType
{
    OFFERS,
    CONTRACTORS
}
namespace FynbusProject
{
    public class CSVImport
    {
        private List<Offer> listOfOffers;

        private static CSVImport instance;

        private CSVImport()
        {
            listOfOffers = new List<Offer>();
        }

        public static CSVImport Instance
        {
            get
            {
                if (instance == null)
                {
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
                    importSucessful = importOffers(filepath);
                    break;
                case fileType.CONTRACTORS:
                    importSucessful = importContractors(filepath);
                    break;
                default: throw new Exception("File Type doesn't exist!");
            }
            return importSucessful;
        }

        private bool importContractors(string filepath)
        {
            throw new NotImplementedException();
        }

        private bool importOffers(string filepath)
        {
            bool isOfferData = false;

            //Get all the info from the CSV file
            string[] data = File.ReadAllLines(filepath, Encoding.GetEncoding("iso-8859-1"));

            //Check if this is a header for the offers
            if (data[0] == "Nummer;Garantivognsnummer;Pris;navn;Virksomhedsnavn;BrugerID;Rutenummer prioritet;Entreprenør prioriter;")
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
                    int vehicleType = int.Parse(collumns[1]);
                    int hoursAvailable = 10; // ??
                    double price = double.Parse(collumns[2]);

                    Offer newOffer = new Offer(offerId, vehicleType, hoursAvailable, price);
                    listOfOffers.Add(newOffer);
                }
            }

            return isOfferData;
        }
    }
}
