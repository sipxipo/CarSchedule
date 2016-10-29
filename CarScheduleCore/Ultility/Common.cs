using System;
using System.Configuration;

namespace CarScheduleCore.Ultility
{
    public static class Common
    {
        public static string CARWASHING_URI = ConfigurationManager.AppSettings["API_URL"].ToString() + "api/carwashing";
        public static string WASHMAN_URI = ConfigurationManager.AppSettings["API_URL"].ToString() + "api/washman";
        public static int TIME_RANGE = int.Parse(ConfigurationManager.AppSettings["TIME_RANGE"]);// minute

        public static DateTime TimeRoundDown(DateTime input)
        {
            return new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0).AddMinutes(-input.Minute % TIME_RANGE);
        }

    }
}
