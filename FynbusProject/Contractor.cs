namespace FynbusProject
{
    public class Contractor
    {
        public string Number { get; private set; }
        public string CompanyName { get; private set; }
        public string PersonName { get; private set; }
        public string EmailAddress { get; private set; }
        public int TypeV2 { get; private set; }
        public int TypeV3 { get; private set; }
        public int TypeV5 { get; private set; }
        public int TypeV6 { get; private set; }
        public int TypeV7 { get; private set; }


        public Contractor(string number, string compName, string persName, string email, int t2, int t3, int t5, int t6, int t7)
        {
            Number = number;
            CompanyName = compName;
            PersonName = persName;
            EmailAddress = email;
            TypeV2 = t2;
            TypeV3 = t3;
            TypeV5 = t5;
            TypeV6 = t6;
            TypeV7 = t7;
        }
    }
}
