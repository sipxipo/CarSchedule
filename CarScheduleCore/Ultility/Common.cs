using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarScheduleCore.Ultility
{
    public static class Common
    {
        public static string CARWASHING_URI = "http://localhost:1863/api/carwashing";
        public static string WASHMAN_URI = "http://localhost:1863/api/washman";
        public static int TIME_RANGE = 5;// minute

        public static DateTime TimeRoundDown(DateTime input)
        {
            return new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, 0).AddMinutes(-input.Minute % TIME_RANGE);
        }

    }
}
