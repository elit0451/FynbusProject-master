using Microsoft.VisualStudio.TestTools.UnitTesting;
using FynbusProject;

namespace FynbusTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class ClearDataTests
    {
        [TestMethod]
        public void ClearDataFromImportedFiles()
        {

            string offerFilepath = @"C:\Users\Kast\Desktop\Fynbus\Flexcel_Fynbus\FakeData_Tests\Test med 3 bud til samme rute\Tilbud_FakeData.csv";
            bool offerFile = CSVImport.Instance.Import(offerFilepath, fileType.OFFERS);

            Assert.IsTrue(offerFile);

            Assert.IsTrue(CSVImport.Instance.ClearData());


        }
    }
}
