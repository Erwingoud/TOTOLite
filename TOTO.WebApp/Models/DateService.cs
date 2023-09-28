using System;
using System.Collections.Generic;

public class DateService
{
    public List<DateTime> GetDaysOfWeek(int year, int weekNumber)
    {
        DateTime startDate = FirstDateOfWeek(year, weekNumber);
        List<DateTime> daysOfWeek = new List<DateTime>();

        for (int i = 0; i < 7; i++)
        {
            daysOfWeek.Add(startDate);
            startDate = startDate.AddDays(1);
        }

        return daysOfWeek;
    }

    public DateTime FirstDateOfWeek(int year, int weekNumber)
    {
        DateTime jan1 = new DateTime(year, 1, 1);
        DateTime firstDayOfWeek = jan1.AddDays((weekNumber - 1) * 7 - (int)jan1.DayOfWeek + (int)DayOfWeek.Monday);
        return firstDayOfWeek;
    }
}