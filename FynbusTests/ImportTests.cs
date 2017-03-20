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

            string offerFilepath = @"C:\Users\Kast\Desktop\Fynbus\Flexcel_Fynbus\FakeData_Tests\Test med 3 bud til samme rute\Tilbud_FakeData.csv";
            bool offerFile = CSVImport.Instance.Import(offerFilepath,fileType.OFFERS);
            
            Assert.IsTrue(offerFile);
        }
    }
}
