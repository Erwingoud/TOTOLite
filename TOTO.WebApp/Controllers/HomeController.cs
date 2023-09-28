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
        public HomeController(ILogger<HomeController> logger, DateService dateService)
        {
            _dateService = dateService;
            _logger = logger;
            _dateService = dateService;
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

            // Pass the year, week number, and future dates as a tuple to the view
            var model = new Tuple<int, int, List<DateTime>>(year.Value, weekNumber.Value, futureWeekDays);

            return View(model);
        }
    }
}