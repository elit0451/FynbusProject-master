using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FynbusProject
{
    public static class CSVImport
    {
        public static bool Import(string filepath)
        {
            bool importSucessful;
            string typeOfFile = CheckTypeOfFile(filepath);
            if(typeOfFile == "Offer")
            {
                importSucessful = true;
            }
            else
            {
                importSucessful = false;
            }
            return importSucessful;
        }

        private static string CheckTypeOfFile(string filepath)
        {
            string fileType = "";
            if(filepath.EndsWith("Tilbud_Skabelon.csv"))
            {
                fileType = "Offer";
            }
            else if(filepath.EndsWith("Stamoplysninger_Skabelon.csv"))
            {
                fileType = "Contractors";
            }

            return fileType;
        }
    }
}
