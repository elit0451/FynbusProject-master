namespace FynbusProject
{
    public class RouteAvaliableHours
    {
        public int AvaliabilityPeriodWeekDays { get; set; }
        public int AvaliabilityPeriodWeekends { get; set; }
        public int AvaliabilityPeriodHolidays { get; set; }

        private static int AmountOfHolidays = 14;
        private static int AmountOfWeekDays = 261;
        private static int AmountOfWeekendsDays = 100;

        public int amountOfHoursContractPeriod()
        {
            return (AvaliabilityPeriodWeekDays * AmountOfWeekDays) +
                   (AvaliabilityPeriodHolidays * AmountOfHolidays) +
                   (AvaliabilityPeriodWeekends * AmountOfWeekendsDays);
        }

    }
}
