using FynbusProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FynbusTests
{
    [TestClass]
    public class ImportTests
    {
        [TestMethod]
        public void ImportOfferFile()
        {

            string offerFilepath = @"C:\Users\Kast\Desktop\Fynbus\Flexcel_Fynbus\FakeData_Tests\Test med 3 bud til samme rute\Tilbud_FakeData.csv";
            bool offerFile = CSVImport.Instance.Import(offerFilepath, fileType.OFFERS);

            Assert.IsTrue(offerFile);
        }

        [TestMethod]
        public void CanImportContractorFile()
        {

            string contractorFilepath = @"C:\Users\Kast\Desktop\Fynbus\Flexcel_Fynbus\FakeData_Tests\Test med 3 bud til samme rute\Stamoplysninger_FakeData.csv";
            bool contractorFile = CSVImport.Instance.Import(contractorFilepath, fileType.CONTRACTORS);

            string contractorFilePath_wrong = @"C:\Users\Kast\Desktop\Fynbus\Flexcel_Fynbus\FakeData_Tests\Test med 3 bud til samme rute\Tilbud_FakeData.csv";
            bool wrongDataformat = CSVImport.Instance.Import(contractorFilePath_wrong, fileType.OFFERS);

            Assert.IsTrue(contractorFile);
            Assert.IsFalse(contractorFile);
        }
    }
}
