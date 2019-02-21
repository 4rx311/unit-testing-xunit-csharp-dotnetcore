using System;

namespace SimonGilbert.Blog.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime RoundToNearestHour(this DateTime dateTime)
        {
            long ticks = dateTime.Ticks + 18000000000;

            return new DateTime(ticks - ticks % 36000000000, dateTime.Kind);
        }
    }
}
