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

        public static string DegreesToDecimal(double degrees, double minutes, double seconds)
        {

            return (degrees + (minutes / 60) + (seconds / 3600)).ToString();
        }

        /// <summary>
        /// Converts a string into radians
        /// </summary>
        /// <param name="myData"></param>
        /// <returns>Radians as a double</returns>
        public static double toRadiansfromDecimalDegrees(string myData)
        {
            return double.Parse(myData) * Math.PI / 180; //in radians
        }

        /// <summary>
        /// Gets the difference between two co-ordinates and converts answer to radians
        /// </summary>
        /// <param name="decimalDegrees"></param>
        /// <param name="decimalDegrees"></param>
        /// <returns>Radians as a double</returns>
        public static double toRadiansfromDecimalDegrees(string myData1, string myData2)
        {
            return (toRadiansfromDecimalDegrees(myData1) - toRadiansfromDecimalDegrees(myData2)); //in radians

            // return (double.Parse(myData1) - double.Parse(myData2)) * Math.PI / 180; //in radians
        }


        /// <summary>
        /// Converts Radians to Degrees
        /// </summary>
        /// <param name="radians"></param>
        /// <returns>Returns degrees as double</returns>
        public static double toDegreesFromRadians(double myData)
        {
            return (myData * 180 / Math.PI + 360) % 360; // in degrees
        }


        /// <summary>
        /// Input data in metres returns in miles
        /// </summary>
        /// <param name="metres"></param>
        /// <returns>Miles as double</returns>
        public static double toMilesFromMetres(double myData)
        {
            return (myData * 0.00062137); // in miles
        }

        /// <summary>
        /// Input data in miles returns in metres
        /// </summary>
        /// <param name="miles"></param>
        /// <returns>Metres as double</returns>
        public static double toMetresFromMiles(double myData)
        {
            return (myData * 1609.344); // in metres
        }

        /// <summary>
        /// Input data in miles returns in kilometres
        /// </summary>
        /// <param name="miles"></param>
        /// <returns>Kilometres as double</returns>
        public static double toKilometresFromMiles(double myData)
        {
            return (myData * 1.609344); // in kilometres
        }

        /// <summary>
        /// Input data in kilometres returns in miles
        /// </summary>
        /// <param name="kilometres"></param>
        /// <returns>miles as double</returns>
        public static double toMilesFromKilometres(double myData)
        {
            return (myData * 0.6213711); // in kilometres
        }

        /// <summary>
        /// Input data in metres returns in nautical miles
        /// </summary>
        /// <param name="metres"></param>
        /// <returns>Nautical Miles as double</returns>
        public static double toNauticalMilesFromMetres(double myData)
        {
            return (myData * 0.00053996); // in nautical miles
        }


        /// <summary>
        /// Input data in nautical miles returns in metres
        /// </summary>
        /// <param name="nautical miles"></param>
        /// <returns>Nautical Miles as double</returns>
        public static double toMetresFromNauticalMiles(double myData)
        {
            return (myData * 1852); // in metres
        }






        /// <summary>
        /// Converts degrees, minutes and seconds into decimal degrees
        /// </summary>
        /// <param name="degrees"></param>
        /// <param name="minutes"></param>
        /// <param name="seconds"></param>
        /// <returns>Decimal degrees as double</returns>

        public static double toDecimalDegreesFromDMS(string myDegrees, string myMinutes, string mySeconds, double cardinal)
        {
            return (double.Parse(myDegrees) + (double.Parse(myMinutes) / 60) +
                             (double.Parse(mySeconds) / 3600)) * cardinal;
        }

        /// <summary>
        /// Converts Decimal degrees to degrees, minutes and seconds
        /// </summary>
        /// <param name="DecimalDegrees"></param>
        /// <returns>String containing degrees, minutes and seconds</returns>
        public static string toDegreesMinutesSecondsFromDecimalDegrees(string myDegrees)
        {
            int seconds = (int)Math.Round(double.Parse(myDegrees) * 3600);
            int degrees = seconds / 3600;
            seconds = Math.Abs(seconds % 3600);
            int minutes = seconds / 60;
            seconds %= 60;

            return degrees + "° " + minutes + "' " + seconds + "\"";
        }
    }
}
