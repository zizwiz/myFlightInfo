using System;
using System.Windows.Forms;
using CenteredMessagebox;
using myFlightInfo.Properties;
//using myFlightInfo.Utils;
using myFlightInfo.utils;

namespace myFlightInfo.libraries
{
    /* ===============================================================================================*/
    /* This is my c# WinForms implementation of the work done by Chris Veness under MIT license       */
    /* and Ed Williams see links below.                                                                */
    /* For fuller explanations please do visit his websites shown below.                               */
    /*                                                                                                */
    /*   Chris Veness                                                                                 */
    /*   https://www.movable-type.co.uk/scripts/latlong.html                                          */
    /*   https://www.movable-type.co.uk/scripts/geodesy-library.html#latlon-spherical                 */
    /*                                                                                                */
    /*   Ed Williams                                                                                  */
    /*   https://www.edwilliams.org/                                                                  */
    /*   https://www.edwilliams.org/avform147.htm                                                     */
    /*                                                                                                */
    /* Consistency rules:                                                                             */
    /*                                                                                                */
    /* use lat/lon for lati­tude/longi­tude in degrees                                                  */
    /* use  φ/λ for lati­tude/longi­tude in radians                                                     */
    /*                                                                                                */
    /* North latitudes and West longitudes are used as positive.                                      */
    /* South latitudes and East longitudes are used as negative.                                      */
    /*                                                                                                */
    /* ===============================================================================================*/

    class GreatCircle
    {

        /// <summary>
        /// This uses the ‘Haversine’ formula to calculate the great-circle distance between two points
        /// That is, the shortest distance over the earth’s surface – giving an ‘as-the-crow-flies’ distance
        /// between the points (ignoring any vertical obstructions like hills that they may need to fly over).
        /// </summary>
        /// <param name="origin_longitude"></param>
        /// <param name="origin_latitude"></param>
        /// <param name="destination_longitude"></param>
        /// <param name="destination_latitude"></param>
        /// <returns>Distance between the two points in metres.</returns>
        public static double Distance(string origin_longitude, string origin_latitude,
                    string destination_longitude, string destination_latitude)
        {
            double earthsRadius = Settings.Default.EarthsRadius;     //earth’s radius in m (mean radius = 6371km)


            double φ1 = Converts.toRadiansfromDecimalDegrees(origin_latitude); //latitude in radians
            double φ2 = Converts.toRadiansfromDecimalDegrees(destination_latitude); // latitude in radians

            //difference in long and lat
            double Δφ = Converts.toRadiansfromDecimalDegrees(destination_latitude, origin_latitude);
            double Δλ = Converts.toRadiansfromDecimalDegrees(destination_longitude, origin_longitude);

            double a = Math.Sin(Δφ / 2) * Math.Sin(Δφ / 2) + Math.Cos(φ1) * Math.Cos(φ2) * Math.Sin(Δλ / 2) * Math.Sin(Δλ / 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return earthsRadius * c; // in metres
        }




        /// <summary>
        /// This formula is for the initial bearing (sometimes referred to as forward azimuth) which if
        /// followed in a straight line along a great-circle arc will take you from the start point to the
        /// end point.
        /// </summary>
        /// <param name="origin_longitude"></param>
        /// <param name="origin_latitude"></param>
        /// <param name="destination_longitude"></param>
        /// <param name="destination_latitude"></param>
        /// <returns>Returns the bearing and its cardinal point for the route starting in both directions</returns>
        public static (double, string, double, string) InitialBearing(string origin_longitude, string origin_latitude,
            string destination_longitude, string destination_latitude)
        {
            //latitudes
            double φ1 = Converts.toRadiansfromDecimalDegrees(origin_latitude);
            double φ2 = Converts.toRadiansfromDecimalDegrees(destination_latitude);

            //longitudes
            double λ1 = Converts.toRadiansfromDecimalDegrees(origin_longitude);
            double λ2 = Converts.toRadiansfromDecimalDegrees(destination_longitude);

            double y = Math.Sin(λ2 - λ1) * Math.Cos(φ2);
            double x = Math.Cos(φ1) * Math.Sin(φ2) - Math.Sin(φ1) * Math.Cos(φ2) * Math.Cos(λ2 - λ1);
            double θ = Math.Atan2(y, x);

            double fbearing = (θ * 180 / Math.PI + 360) % 360; // forward bearing in degrees
            double rbearing = (fbearing + 180) % 360; // reverse bearing in degrees

            return (fbearing, HelpfulFunctions.getCardinalPointsFromDecimalDegrees(fbearing),
                rbearing, HelpfulFunctions.getCardinalPointsFromDecimalDegrees(rbearing));
        }

        /// <summary>
        /// This is the half-way point along a great circle path between the two points.
        /// The midpoint may not be located half-way between latitudes/longitudes
        /// </summary>
        /// <param name="origin_longitude"></param>
        /// <param name="origin_latitude"></param>
        /// <param name="destination_longitude"></param>
        /// <param name="destination_latitude"></param>
        /// <returns></returns>
        public static (double, double) MidPoint(string origin_longitude, string origin_latitude,
            string destination_longitude, string destination_latitude)
        {
            //latitudes
            double φ1 = Converts.toRadiansfromDecimalDegrees(origin_latitude);
            double φ2 = Converts.toRadiansfromDecimalDegrees(destination_latitude);

            //longitudes
            double λ1 = Converts.toRadiansfromDecimalDegrees(origin_longitude);

            //difference in long and lat
            double Δλ = Converts.toRadiansfromDecimalDegrees(destination_longitude, origin_longitude);

            // get cartesian coordinates for the two points
            double[] A = { Math.Cos(φ1), 0, Math.Sin(φ1) }; // place point A on prime meridian y=0
            double[] B = { Math.Cos(φ2) * Math.Cos(Δλ), Math.Cos(φ2) * Math.Sin(Δλ), Math.Sin(φ2) };

            // vector to midpoint is sum of vectors to two points (no need to normalise)
            double[] C = { A[0] + B[0], A[1] + B[1], A[2] + B[2] };

            double φm = Math.Atan2(C[2], Math.Sqrt(C[0] * C[0] + C[1] * C[1]));
            double λm = λ1 + Math.Atan2(C[1], C[0]);

            double lat = Converts.toDegreesFromRadians(φm);
            double lon = Converts.toDegreesFromRadians(λm);

            return (lat, lon);
        }


        /// <summary>
        /// Find a destination co-ordinates from start co-ordinates, bearing and distance.
        /// </summary>
        /// <param name="originLongitude"></param>
        /// <param name="originLatitude"></param>
        /// <param name="bearing"></param>
        /// <param name="distance"></param>
        /// <returns>Destination as tuple double of latitude and longitude</returns>
        public static (double, double) FindDestination(double originLongitude, double originLatitude, double bearing, double distance)
        {
            double λ1 = originLongitude;
            double φ1 = originLatitude;
            double θ = bearing;

            //Get the angular distance in radians
            double δ = distance / Settings.Default.EarthsRadius; // Earth radius set in settings

            double sinφ2 = Math.Sin(φ1) * Math.Cos(δ) + Math.Cos(φ1) * Math.Sin(δ) * Math.Cos(θ);
            double φ2 = Math.Asin(sinφ2);

            double y = Math.Sin(θ) * Math.Sin(δ) * Math.Cos(φ1);
            double x = Math.Cos(δ) - Math.Sin(φ1) * sinφ2;
            double λ2 = λ1 + Math.Atan2(y, x);

            return (φ2, λ2);
        }

        /// <summary>
        /// Intersection of two paths given start points and bearings
        /// </summary>
        /// <param name="Longitude1"></param>
        /// <param name="Latitude1"></param>
        /// <param name="bearing1"></param>
        /// <param name="Longitude2"></param>
        /// <param name="Latitude2"></param>
        /// <param name="bearing2"></param>
        /// <returns>returns latitude and longitude as doubles</returns>
        public static (double, double) FindIntersectionOfTwoPaths(double Longitude1, double Latitude1, double bearing1,
            double Longitude2, double Latitude2, double bearing2)
        {

            /*
             * We use some error codes here to tell the GUI of error cases.
             * We send back error as long and lat and decipher in GUI.
             * 999 = infinite intersections.
             * 998 = ambiguous intersection. On opposite sides of globe.
             * 997 = coincident (same) points.
             * You can add more if you need.
             */
            double φ1 = Latitude1;
            double λ1 = Longitude1;
            double θ13 = bearing1;

            double φ2 = Latitude2;
            double λ2 = Longitude2;
            double θ23 = bearing2;

            double Δφ = φ2 - φ1;
            double Δλ = λ2 - λ1;

            // angular distance p1-p2
            double δ12 = 2 * Math.Asin(Math.Sqrt(Math.Sin(Δφ / 2) * Math.Sin(Δφ / 2)
                + Math.Cos(φ1) * Math.Cos(φ2) * Math.Sin(Δλ / 2) * Math.Sin(Δλ / 2)));
            if (Math.Abs(δ12) < Double.Epsilon) return (997, 997); // coincident points

            // initial/final bearings between points
            double cosθa = (Math.Sin(φ2) - Math.Sin(φ1) * Math.Cos(δ12)) / (Math.Sin(δ12) * Math.Cos(φ1));
            double cosθb = (Math.Sin(φ1) - Math.Sin(φ2) * Math.Cos(δ12)) / (Math.Sin(δ12) * Math.Cos(φ2));
            double θa = Math.Acos(Math.Min(Math.Max(cosθa, -1), 1)); // protect against rounding errors
            double θb = Math.Acos(Math.Min(Math.Max(cosθb, -1), 1)); // protect against rounding errors

            double θ12 = Math.Sin(λ2 - λ1) > 0 ? θa : 2 * Math.PI - θa;
            double θ21 = Math.Sin(λ2 - λ1) > 0 ? 2 * Math.PI - θb : θb;

            double α1 = θ13 - θ12; // angle 2-1-3
            double α2 = θ21 - θ23; // angle 1-2-3

            if (Math.Sin(α1) == 0 && Math.Sin(α2) == 0) return (999, 999); // infinite intersections
            if (Math.Sin(α1) * Math.Sin(α2) < 0) return (998, 998);        // ambiguous intersection (antipodal/360°)

            double cosα3 = -Math.Cos(α1) * Math.Cos(α2) + Math.Sin(α1) * Math.Sin(α2) * Math.Cos(δ12);

            double δ13 = Math.Atan2(Math.Sin(δ12) * Math.Sin(α1) * Math.Sin(α2), Math.Cos(α2) + Math.Cos(α1) * cosα3);

            double φ3 = Math.Asin(Math.Min(Math.Max(Math.Sin(φ1) * Math.Cos(δ13) + Math.Cos(φ1) * Math.Sin(δ13) * Math.Cos(θ13), -1), 1));

            double Δλ13 = Math.Atan2(Math.Sin(θ13) * Math.Sin(δ13) * Math.Cos(φ1), Math.Cos(δ13) - Math.Sin(φ1) * Math.Sin(φ3));
            double λ3 = λ1 + Δλ13;

            return (φ3, λ3);
        }

        /// <summary>
        /// Returns co-ordinates of a % of track completed.
        /// </summary>
        /// <param name="Longitude1"></param>
        /// <param name="Latitude1"></param>
        /// <param name="Longitude2"></param>
        /// <param name="Latitude2"></param>
        /// <param name="fraction"></param>
        /// <returns>Doubles for Longitude, Latitude and Distance along</returns>
        public static (double, double, double) FindintermediatePoint(string Longitude1, string Latitude1,
            string Longitude2, string Latitude2, double fraction)
        {
            //if (!(point instanceof LatLonSpherical)) point = LatLonSpherical.parse(point); // allow literal forms
            //if (this.equals(point)) return new LatLonSpherical(this.lat, this.lon); // coincident points

            double φ1 = Converts.toRadiansfromDecimalDegrees(Latitude1);
            double λ1 = Converts.toRadiansfromDecimalDegrees(Longitude1);
            double φ2 = Converts.toRadiansfromDecimalDegrees(Latitude2);
            double λ2 = Converts.toRadiansfromDecimalDegrees(Longitude2);

            if ((φ1 == φ2) && (λ1 == λ2)) return (997, 997, 997);


            // angular distance between points
            double Δφ = φ2 - φ1;
            double Δλ = λ2 - λ1;
            double a = Math.Sin(Δφ / 2) * Math.Sin(Δφ / 2) + Math.Cos(φ1) * Math.Cos(φ2) * Math.Sin(Δλ / 2) * Math.Sin(Δλ / 2);
            double δ = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a)); // angular distance
            double d = (Settings.Default.EarthsRadius * δ)* fraction; //distance traveled along track

            double A = Math.Sin((1 - fraction) * δ) / Math.Sin(δ);
            double B = Math.Sin(fraction * δ) / Math.Sin(δ);

            double x = (A * Math.Cos(φ1) * Math.Cos(λ1)) + (B * Math.Cos(φ2) * Math.Cos(λ2));
            double y = (A * Math.Cos(φ1) * Math.Sin(λ1)) + (B * Math.Cos(φ2) * Math.Sin(λ2));
            double z = A * Math.Sin(φ1) + B * Math.Sin(φ2);

            double φ3 = Math.Atan2(z, Math.Sqrt((x * x) + (y * y)));
            double λ3 = Math.Atan2(y, x);

            return (φ3, λ3, d);

        }



        //Calculate settings for altitude at destination
        /*
         * var values = MyFunction();
           var firstValue = values.Item1;
           var secondValue = values.Item2;
           var thirdValue = values.Item3;

            (string, string, string)MyFunction()

         */
    }
}
