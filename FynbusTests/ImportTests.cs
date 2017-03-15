using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FynbusProject;

namespace FynbusTests
{
    [TestClass]
    public class ImportTests
    {
        [TestMethod]
        public void ImportOfferFile()
        {
            string contractorFilepath = @"C:\Users\Kast\Desktop\Fynbus\Flexcel_Fynbus\FakeData_Tests\Stamoplysninger_Skabelon.csv";
            bool contractorFile = CSVImport.Import(contractorFilepath);

            string offerFilepath = @"C:\Users\Kast\Desktop\Fynbus\Flexcel_Fynbus\FakeData_Tests\Tilbud_Skabelon.csv";
            bool offerFile = CSVImport.Import(offerFilepath);

            Assert.IsFalse(contractorFile);
            Assert.IsTrue(offerFile);
        }
    }
}
