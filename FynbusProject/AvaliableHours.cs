using System.Collections.Generic;

namespace FynbusProject
{
    public class AvaliableHours
    {

        private static AvaliableHours instance = null;

        public static AvaliableHours Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AvaliableHours();
                }
                return instance;

            }
        }

        private static Dictionary<int, RouteAvaliableHours> routesAvaliableHours = new Dictionary<int, RouteAvaliableHours>();

        private AvaliableHours()
        {
            InitializeData();
        }

        private static void InitializeData()
        {
            routesAvaliableHours.Add(1, new RouteAvaliableHours()
            {
                AvaliabilityPeriodWeekends = 0,
                AvaliabilityPeriodWeekDays = 9,
                AvaliabilityPeriodHolidays = 0
            });
        }


        public static int GetAvaliableHours(int routenumber)
        {
            return routesAvaliableHours[routenumber].amountOfHoursContractPeriod();
        }
    }
}
