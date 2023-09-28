using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using TOTO.WebApp.Models;

namespace TOTO.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DateService _dateService;
        private readonly HolidayService _holidayService;
        public HomeController(ILogger<HomeController> logger, DateService dateService, HolidayService holidayService)
        {
            _dateService = dateService;
            _logger = logger;
            _dateService = dateService;                                                                   
            _holidayService = holidayService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ShowDaysOfWeek(int? year, int? weekNumber)
        {
            if (!year.HasValue || !weekNumber.HasValue)
            {
                // Default to current year and week if not provided
                year = DateTime.Now.Year;
                weekNumber = GetIso8601WeekOfYear(DateTime.Now);
            }

            ViewBag.Year = year;
            ViewBag.WeekNumber = weekNumber;

            List<DateTime> daysOfWeek = _dateService.GetDaysOfWeek(year.Value, weekNumber.Value);
            return View(daysOfWeek);
        }

        public static int GetIso8601WeekOfYear(DateTime date)
        {
            return CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        public IActionResult ShowFutureWeek(int? year, int? weekNumber)
        {
            if (!year.HasValue || !weekNumber.HasValue)
            {
                // Default to current year and week if not provided
                year = DateTime.Now.Year;
                weekNumber = GetIso8601WeekOfYear(DateTime.Now);
            }

            ViewBag.Year = year;
            ViewBag.WeekNumber = weekNumber;

            // Calculate future dates for the specified week
            List<DateTime> futureWeekDays = _dateService.GetFutureWeekDays(year.Value, weekNumber.Value);

            // Create a dictionary to store weekday-holiday mappings
            var weekdayHolidayMap = new Dictionary<DateTime, bool>();

            foreach (DateTime futureWeekDay in futureWeekDays)
            {
                bool isHoliday = _holidayService.IsHoliday(futureWeekDay);
                weekdayHolidayMap[futureWeekDay] = isHoliday;
            }

            // Create a tuple containing year, week number, and the weekday-holiday map
            var model = new Tuple<int, int, Dictionary<DateTime, bool>>(year.Value, weekNumber.Value, weekdayHolidayMap);

            return View(model);
        }
    }
}