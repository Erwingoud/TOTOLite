namespace TOTO.WebApp.Models
{
    public class HolidayService
    {
        private readonly List<DateTime> _holidays = new List<DateTime>
    {
        new DateTime(DateTime.Now.Year, 1, 1),     // New Year's Day
        new DateTime(DateTime.Now.Year, 12, 25),   // Christmas Day
        new DateTime(DateTime.Now.Year, 12, 26),   // Second Christmas Day
        new DateTime(DateTime.Now.Year, 4, 12),    // Kingsday (NL)
    };

        public bool IsHoliday(DateTime date)
        {
            return _holidays.Contains(date.Date);
        }
    }
}
