using System;

namespace myFlightInfo.utils
{
    class Converts
    {
        public static string DecimalToDegrees(double decimal_degrees)
        {
            string direction = "W";
            int sec = (int)Math.Round(decimal_degrees * 3600);
            int deg = sec / 3600;
            sec = Math.Abs(sec % 3600);
            int min = sec / 60;
            sec %= 60;

            if (deg < 0) direction = "E";

            return deg + "° " + min + "' " + sec + "\" " + direction;

        }


    }
}
