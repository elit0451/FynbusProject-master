using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FynbusProject
{
    class Contractor
    {
        private string _companyName;
        private string _personName;
        private string _emailAddress;
        private int _typeV2;
        private int _typeV3;
        private int _typeV5;
        private int _typeV6;
        private int _typeV7;


        public Contractor(string compName, string persName, string email, int t2, int t3, int t5, int t6, int t7)
        {
            _companyName = compName;
            _personName = persName;
            _emailAddress = email;
            _typeV2 = t2;
            _typeV3 = t3;
            _typeV5 = t5;
            _typeV6 = t6;
            _typeV7 = t7;
        }
    }
}
