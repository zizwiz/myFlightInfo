using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myFlightInfo.utils
{
    class HelpfulFunctions
    {

        /// <summary>
        /// Constrain degrees to range 0..360 (for bearings); e.g. -1 => 359, 361 => 1.
        ///
        /// </summary>
        /// <param name="decimalDegrees"></param>
        /// <returns>degrees within range 0..360 as double</returns>
        public static double UnWrap360(double myDegrees)
        {
            if (0 <= myDegrees && myDegrees < 360) return myDegrees; // avoid rounding due to arithmetic ops if within range

            // bearing wrapping requires a sawtooth wave function with a vertical offset equal to the
            // amplitude and a corresponding phase shift; this changes the general sawtooth wave function from
            //     f(x) = (2ax/p - p/2) % p - a
            // to
            //     f(x) = (2ax/p) % p
            // where a = amplitude, p = period, % = modulo; however, JavaScript '%' is a remainder operator
            // not a modulo operator - for modulo, replace 'x%n' with '((x%n)+n)%n'
            double x = myDegrees, a = 180, p = 360;
            return (((2 * a * x / p) % p) + p) % p;
        }

        /// <summary>
        /// Finds cardinal point of decimal degrees bearing.
        /// </summary>
        /// <param name="bearing"></param>
        /// <returns>String of the cardinal point</returns>
        public static string getCardinalPointsFromDecimalDegrees(double bearing)
        {
            /*
             * We use the Meterological cardinal points. Others explained below.
             * 1) Cardinal: with 4 cardinal points: north, south, east, west
               2) Intercardinal: with 8 points, 4 cardinal + 4 ordinals (NE, SE, SW, NW)
               3) Meteorological: with 16 points, 8 intercardinal + intermediate points between cardinal and ordinal points, such as north-northeast (NNE)
               4) Mariner: has 32 points, 16 + points such as northeast by north (NEbN) between north-northeast and northeast.
               5) "Extended" Mariner: with 128 points, extended the 32-point system with half-and quarter-points to allow 128 directions.
             */

            // Metreological Cardinal points
            // Note we have 17 items as 360° wraps to the same as 0°.
            string[] cardinals = {
                "N", "NNE", "NE", "ENE",
                "E", "ESE", "SE", "SSE",
                "S", "SSW", "SW", "WSW",
                "W", "WNW", "NW", "NNW",
                "N"
            };

            //unwrap the bearing in case it is more than 360°
            string cardinal = cardinals[int.Parse(Math.Round(HelpfulFunctions.UnWrap360(bearing) / 360 * 16).ToString())];

            return cardinal;
        }
    }
}
